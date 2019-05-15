using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Orm.Model.EnumDefine
{
    /// <summary>
    /// 基础控制配置
    /// </summary>
    [Serializable]
    public class BaseControlConfig
    {
        #region 属性
        private string _key;
        /// <summary>
        /// 键
        /// </summary>
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private string _field;
        /// <summary>
        /// 文件id
        /// </summary>
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        private string _storedProcedure;
        /// <summary>
        /// 存储过程
        /// </summary>
        public string StoredProcedure
        {
            get { return _storedProcedure; }
            set { _storedProcedure = value; }
        }

        private string _orderByExpression;
        /// <summary>
        ///表达顺序
        /// </summary>
        public string OrderByExpression
        {
            get { return _orderByExpression; }
            set { _orderByExpression = value; }
        }

        private string _whereCondition;
        /// <summary>
        /// Where条件
        /// </summary>
        public string WhereCondition
        {
            get { return _whereCondition; }
            set { _whereCondition = value; }
        }

        private string _id;
        /// <summary>
        /// GUID
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        Dictionary<string, object> pramarter;
        /// <summary>
        /// 变量
        /// </summary>
        public Dictionary<string, object> Pramarter
        {
            get
            {
                if (pramarter == null)
                {
                    pramarter = new Dictionary<string, object>();
                    pramarter.Add(":o", this._orderByExpression);
                }
                return pramarter;
            }
        }

        /// <summary>
        /// 是不是枚举
        /// </summary>
        public bool IsEnum
        {
            get
            {
                if (this._storedProcedure.StartsWith("Enum"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 执行sql语句的模板
        /// </summary>
        public string SQLFormat
        {
            get
            {
                if (this._whereCondition.ToLower().Contains("drop")
                    || this._whereCondition.ToLower().Contains("delete"))
                {
                    throw new FormatException(string.Format("配置项{0}配置了非法项", this._key));
                }

                string format = @"select :field from :tbName where :where ";
                string orderby = @" order by :o";
                if (!string.IsNullOrEmpty(this._orderByExpression))
                {
                    format = format + orderby;
                }

                format = format.Replace(":tbName", this._storedProcedure);
                format = format.Replace(":field", this._field);
                format = format.Replace(":where", this._whereCondition);
                return format;
            }
        }
    }
    #endregion
    /// <summary>
    /// 
    /// </summary>
    public enum MsgStates
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("成功")]
        Success = 0,
        /// <summary>
        /// 
        /// </summary>
        [Description("警告")]
        Waring,
        /// <summary>
        /// 
        /// </summary>
        [Description("警告列表")]
        WaringList,
        /// <summary>
        /// 
        /// </summary>
        [Description("错误")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [Description("错误列表")]
        ErrorList
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ParamDelimiter
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [Description("中括号分隔符")]
        Bracket = 0,

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [Description("逗号分隔符")]
        Comma = 1,

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [Description("竖线分隔符")]
        VerticalLine = 2,
    }
    //public enum EnumChargeDaysTypeCalculateMode
    //{
    //    UnIncludeLastDay = 1,//不包括最后一天(出院结算时)
    //    IncludeLastDay = 2,//包括最后一天(出院结算时)
    //}
    /// <summary>
    /// 
    /// </summary>
    public enum ToolbarStatus
    {
        /// <summary>
        /// 
        /// </summary>
        All = 0,
        /// <summary>
        /// 
        /// </summary>
        View = 1,
        /// <summary>
        /// 
        /// </summary>
        Edit = 2,
        /// <summary>
        /// 
        /// </summary>
        Add = 4
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EnumAudit
    {
        /// <summary>
        /// 
        /// </summary>
        审核,
        /// <summary>
        /// 
        /// </summary>
        删除,
        /// <summary>
        /// 
        /// </summary>
        编辑
    }
    /// <summary>
    /// 
    /// </summary>
    public enum HotKeys
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        F1,
        /// <summary>
        /// 
        /// </summary>
        F2,
        /// <summary>
        /// 
        /// </summary>
        F3,
        /// <summary>
        /// 
        /// </summary>
        F4,
        /// <summary>
        /// 
        /// </summary>
        F5,
        /// <summary>
        /// 
        /// </summary>
        F6,
        /// <summary>
        /// 
        /// </summary>
        F7,
        /// <summary>
        /// 
        /// </summary>
        F8,
        /// <summary>
        /// 
        /// </summary>
        F9,
        /// <summary>
        /// 
        /// </summary>
        F10,
        /// <summary>
        /// 
        /// </summary>
        F11,
        /// <summary>
        /// 
        /// </summary>
        F12,
        /// <summary>
        /// 
        /// </summary>
        N
    }
    /// <summary>
    /// 
    /// </summary>
    public enum EnumFileTempateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        未下载 = 0,
        /// <summary>
        /// 
        /// </summary>
        已下载 = 1,
        /// <summary>
        /// 
        /// </summary>
        正在下载 = 2
    }
}


