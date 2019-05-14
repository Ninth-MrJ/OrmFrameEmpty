﻿namespace Orm.Framework.Services
{

    /// <summary>
    /// 任务调度平台任务基类
    /// </summary>
    public interface IJob
    {
        /// <summary>
        /// 实现作业主逻辑
        /// </summary>
        bool Execute(BaseJobContext context);

    }
}
