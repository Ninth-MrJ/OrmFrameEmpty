using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
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

    public enum MsgStates
    {
        [Description("成功")]
        Success = 0,
        [Description("警告")]
        Waring,
        [Description("警告列表")]
        WaringList,
        [Description("错误")]
        Error,
        [Description("错误列表")]
        ErrorList
    }
    public enum ParamDelimiter
    {
        [DataMember]
        [Description("中括号分隔符")]
        Bracket = 0,

        [DataMember]
        [Description("逗号分隔符")]
        Comma = 1,

        [DataMember]
        [Description("竖线分隔符")]
        VerticalLine = 2,
    }
    public enum EnumChargeDaysTypeCalculateMode
    {
        UnIncludeLastDay = 1,//不包括最后一天(出院结算时)
        IncludeLastDay = 2,//包括最后一天(出院结算时)
    }

    public enum ToolbarStatus
    {
        All = 0,
        View = 1,
        Edit = 2,
        Add = 4
    }
    /// <summary>
    /// 一级菜单
    /// </summary>
    public enum EnumCanAccessFirstModul
    {
        前台咨询,
        门诊就诊,
        库存管理,
        数据分析,
        系统维护,
        一键诊疗
    }
    /// <summary>
    /// 二级菜单 界面名称 
    /// </summary>
    public enum EnumCanAccesTwoModul
    {
        科室分检,
        治疗方案,
        问诊就诊,
    }
    /// <summary>
    ///所允许用户做的 操作
    /// </summary>
    public enum EnumAudit
    {
        审核,
        删除,
        编辑
    }
    public enum FuctionAccess
    {
        Browse = 1,
        Add = 2,
        Modify = 3,
        Delete = 4,
        Check = 5,
        Public = 6,
        Location = 7,
        Other = 8,
        Doctor = 10,
        User = 11
    }
    public enum HotKeys
    {
        None,
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        N,
        D,
        S,
        Q,
        P
    }
    public enum ToolbarItemType
    {
        Button = 0,
        Dropdown = 1
    }
    public enum EnumFileTempateStatus
    {
        未下载 = 0,
        已下载 = 1,
        正在下载 = 2
    }
}


