namespace Orm.Framework.Services
{
    /// <summary>
    /// IObjectPoolʵ����ʹ�øö��������еĶ���Ĵ��������ٺͶۻ�
    /// </summary>
    public interface IPoolableObjectFactory<T> where T : class
    {
        /// <summary>
        /// �ɳص��ø÷������ڴ���������ʵ��
        /// </summary>
        /// <returns></returns>
        T CreateObject();

        /// <summary>
        /// �ɳص��ø÷����������ٶ���
        /// </summary>
        /// <param name="o"></param>
        void DestroyObject(T o);

        /// <summary>
        /// �ۻ�(���ö���״̬)����ÿ�ζ���黹����ʱ���ø÷�������״̬
        /// </summary>
        /// <param name="o"></param>
        void PassivateObject(T o);
    }
}