﻿using Orm.Framework.Services;
using Orm.IServices.ITestSercive;

namespace Orm.Config
{
    /// <summary>
    /// 全局服务类
    /// </summary>
    public static class Service
    {
        #region 保留旧域接口
        private static IEmitService _EmitService;
        private static IDBClientBase _DBClientBase;

        /// <summary>
        /// 服务单例，客户端的数据库操作
        /// </summary>
        public static IDBClientBase DBClientService
        {
            get
            {
                if (_DBClientBase == null)
                {
                    _DBClientBase = ServiceTaker.GetRemoteService<IDBClientBase>();
                }
                return _DBClientBase;
            }
        }


        /// <summary>
        ///List类型转换服务
        /// </summary>
        public static IEmitService EmitService
        {
            get
            {
                if (_EmitService == null)
                {
                    _EmitService = ServiceTaker.GetService<IEmitService>();
                }
                return _EmitService;
            }
        }

        #endregion

        private static ITestDemoServices _TestDemoServices;

        public static ITestDemoServices TestDemoServices
        {
            get
            {
                if (_TestDemoServices == null)
                {
                    _TestDemoServices = ServiceTaker.GetRemoteService<ITestDemoServices>();
                }
                return _TestDemoServices;
            }
        }

    }
}
