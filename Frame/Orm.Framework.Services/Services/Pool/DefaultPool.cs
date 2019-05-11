using System;
using System.Collections;
using System.Collections.Generic;

namespace Orm.Framework.Services
{
    /// <summary>
    /// �̰߳�ȫ�Ķ���ص�Ĭ��ʵ��,�ش�Сһ����ʼ��ȷ�������޸�
    /// </summary>
    public class DefaultPool<T> : IObjectPool<T> where T : class
    {
        private readonly object lockObj = new object();
        private readonly IPoolableObjectFactory<T> factory;
        private int size = 0;
        private IList free = new List<T>();
        private IList busy = new List<T>();

        /// <summary>
        /// ���캯����ʹ��Ĭ�ϳش�С
        /// </summary>
        /// <param name="factory"></param>
        public DefaultPool(IPoolableObjectFactory<T> factory) : this(factory,0)
        {
        }

        /// <summary>
        /// ���캯��,Ĭ�ϳش�СΪ16
        /// </summary>
        /// <param name="factory">the factory used to instantiate and manage lifecycle of pooles object</param>
        /// <param name="size">����ش�С</param>
        public DefaultPool(IPoolableObjectFactory<T> factory, int size)
        {
            this.factory = factory;
            this.size = size <= 0 ? 16 : size;
            Init(this.size);
        }

        /// <summary>
        /// ��ʼ����
        /// </summary>
        protected virtual void Init(int size)
        {
            for (int i = 0; i < size; i++)
            {
                free.Add(factory.CreateObject());
            }
        }

        #region IObjectPool ��Ա
        /// <summary>
        /// �Ӷ�����л�ȡһ�����ö���
        /// </summary>
        public virtual T Get()
        {
            T t= DoBorrow ();
            if (t != null) return t; 
            
            throw new ApplicationException("�������û�п��ö���");//No more valid object in pool        
        }

        /// <summary>
        /// �ͷ�һ������ض����
        /// </summary>
        /// <param name="o"></param>
        public virtual bool Release(T o)
        {
            if (o == null) return false;

            return DoReturn(o);
        }

        /// <summary>
        /// �رճأ������ٳ���ȫ������
        /// </summary>
        public virtual void Close()
        {
            lock (lockObj)
            {
                //1.���ͷ��Ѿ�ʹ�õĶ���[����öۻ�����]
                foreach (T o in busy)
                {
                    DoReturn(o);
                }

                //2.����ȫ������
                foreach (T o in free)
                {
                    factory.DestroyObject(o);
                }

                //3.�ͷ��ڲ���free��busy����
                free = busy = new List<T>();
            }
        }

        /// <summary>
        /// �����Ѿ�ʹ�õĶ�����
        /// </summary>
        public virtual int ActiveObjects
        {
            get { return this.busy.Count; }
        }

        /// <summary>
        /// ���п��еĶ�����
        /// </summary>
        public virtual int IdleObjects
        {
            get { return this.free.Count; }
        }

        #endregion

        /// <summary>
        /// �ӳ��з���һ�����󹩵��÷�ʹ��
        /// </summary>
        /// <returns></returns>
        private T DoBorrow()
        {
            lock (lockObj)
            {
                while (free.Count > 0)
                {
                    int i = free.Count - 1;
                    T o = (T)free[i];
                    free.RemoveAt(i);
                    busy.Add(o);
                    return o;
                }
            }
            return default(T);
        }

        /// <summary>
        /// �ͷ�һ������ض���أ��ڲ�����öۻ�����ķ���
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        private bool DoReturn(T o)
        {
            lock (lockObj)
            {
                if (busy.Contains(o))
                {
                    busy.Remove(o);
                    factory.PassivateObject(o);
                    free.Add(o);
                    return true;
                }
                return false;
            }
        }
    }
}