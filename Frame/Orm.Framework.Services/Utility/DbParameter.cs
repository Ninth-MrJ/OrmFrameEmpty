﻿using System.Collections.Generic;
using System.Dynamic;

namespace Orm.Framework.Services
{
    public delegate object delegateDynamic(dynamic Sender, params object[] objs);

    public class DelegateObj
    {
        private delegateDynamic _delegate;

        public delegateDynamic CallMethod
        {
            get { return _delegate; }
        }
        private DelegateObj(delegateDynamic D)
        {
            _delegate = D;
        }
        /// <summary>  
        /// 构造委托对象
        /// </summary>  
        /// <param name="D"></param>  
        /// <returns></returns>  
        public static DelegateObj Function(delegateDynamic D)
        {
            return new DelegateObj(D);
        }
    }


    public class DbParameter : DynamicObject
    {
        //保存对象动态定义的属性值  
        private Dictionary<string, object> _values;
        public DbParameter()
        {
            _values = new Dictionary<string, object>();
        }

        /// <summary>  
        /// 获取属性值  
        /// </summary>  
        /// <param name="propertyName"></param>  
        /// <returns></returns>  
        public object GetPropertyValue(string propertyName)
        {
            if (_values.ContainsKey(propertyName) == true)
            {
                return _values[propertyName];
            }
            return null;
        }

        /// <summary>  
        /// 设置属性值  
        /// </summary>  
        /// <param name="propertyName"></param>  
        /// <param name="value"></param>  
        public void SetPropertyValue(string propertyName, object value)
        {
            if (_values.ContainsKey(propertyName) == true)
            {
                _values[propertyName] = value;
            }
            else
            {
                _values.Add(propertyName, value);
            }
        }

        /// <summary>  
        /// 实现动态对象属性成员访问的方法，得到返回指定属性的值  
        /// </summary>  
        /// <param name="binder"></param>  
        /// <param name="result"></param>  
        /// <returns></returns>  
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = GetPropertyValue(binder.Name);
            return result == null ? false : true;
        }

        /// <summary>  
        /// 实现动态对象属性值设置的方法。  
        /// </summary>  
        /// <param name="binder"></param>  
        /// <param name="value"></param>  
        /// <returns></returns>  
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            SetPropertyValue(binder.Name, value);
            return true;
        }
        /// <summary>  
        /// 动态对象动态方法调用时执行的实际代码  
        /// </summary>  
        /// <param name="binder"></param>  
        /// <param name="args"></param>  
        /// <param name="result"></param>  
        /// <returns></returns>  
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var theDelegateObj = GetPropertyValue(binder.Name) as DelegateObj;
            if (theDelegateObj == null || theDelegateObj.CallMethod == null)
            {
                result = null;
                return false;
            }
            result = theDelegateObj.CallMethod(this, args);
            return true;
        }
        public override bool TryInvoke(InvokeBinder binder, object[] args, out object result)
        {
            return base.TryInvoke(binder, args, out result);
        }
    }


}
