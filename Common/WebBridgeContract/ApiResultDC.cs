﻿namespace Orm.WebBridgeContract
{
    public class ApiResultDC
    {
        /// <summary>
        /// 正确执行的Json返回。
        /// </summary>
        public string JsonValue { get; set; }

        /// <summary>
        /// 返回的类型限定名。是反射的目标。
        /// </summary>
        public string TypeQualifiedName { get; set; }

        /// <summary>
        /// 是否发生异常。
        /// </summary>
        public bool HasException { get; set; }

        /// <summary>
        /// 异常消息。
        /// </summary>
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// 异常堆栈。
        /// </summary>
        public string ExceptionStack { get; set; }

        /// <summary>
        /// 异常类型1:InformationException 2:WarningException 3:ErrorException
        /// </summary>
        public int ExceptionState { get; set; }

        public ApiResultDC()
        {
            HasException = false;
        }
    }
}
