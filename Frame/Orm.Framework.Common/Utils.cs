using Orm.Framework.Services;
using Orm.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Orm.Framework.Common
{
    public class Utils
    {
        private static DBServiceBase _db = new DBServiceBase();
        public static string GetSystemSetting(string keyNum)
        {

            var list = _db.GetList<GblSetting>(t => t.KeyNum == keyNum);

            if (list != null && list.Count() > 0)
            {
                return list.ElementAt(0).SetValue;
            }
            throw new Orm.Utilities.InformationException(string.Format("参数{0}没有设置，调用失败，请通知系统管理员！", keyNum));
        }




        public static bool CheckSettingContainFormat(string keyNum, object item)
        {
            string keyValue = GetSystemSetting(keyNum);
            if (keyValue == string.Empty) return true;
            string[] itemIds = item.ToString().Split(',', '，', '|');
            for (int i = 0; i < itemIds.Length; i++)
            {
                if (keyValue.Contains(string.Format("[{0}]", itemIds[i])))
                {
                    return true;
                }
            }
            return false;
        }
        //---public static bool CheckIsWzGysHouseId(int roomId)
        //{
        //    int locationId = Convert.ToInt32(_db.GetModelByGuid<BsHouse>(roomId).HospitalId);
        //    List<BsHouse> lstHouse = _db.GetAllList<BsHouse>();
        //    foreach (BsHouse infoHouse in lstHouse)
        //    {
        //        if (infoHouse.HospitalId == locationId && infoHouse.GUID == Convert.ToInt32(Utils.GetSystemSetting("WzGysHouseId")))
        //        { 
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="operType">操作类型：1-新增 2-删除 3-修改  </param>
        /// <param name="TableDesc">操作的表的描述</param>
        /// <param name="operTableName">操作的表名</param>
        /// <param name="operId">操作人</param>
        /// <param name="operName">操作人名称</param>
        /// <param name="machineName">客户端机器名</param>
        /// <param name="operIP">客户端IP</param>
        /// <param name="operDate">操作时间</param>
        /// <param name="operContent">日志内容</param>
        /// <param name="operTableID">主键值得ID</param>
        /// <param name="columnName">列名</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        /// <returns></returns>
        public static Trace GetLogFieldChanged(int operType, string TableDesc, string operTableName, string operId, string operName, string machineName, string operIP, DateTime operDate, string operContent, string operTableID = "", string columnName = "", string oldValue = "", string newValue = "")
        {
            Trace log = new Trace
            {
                Messages = operContent,
                OperateType = operType.ToString(),
                Type = operTableName,
                UserID = operId,
                RecordId = operTableID,
                Ip = operIP,
                CreateDate = operDate,
                WorkFlow = TableDesc
            };
            return log;
        }



        /// <summary>
        /// Fn_TruncDate
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DateTime GetTruncDate(DateTime dt)
        {
            return dt.AddDays(dt.Day - 0);
        }

        /// <summary>
        /// Fn_GetStrDate
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public string GetStrDate(DateTime strDate)
        {
            if (strDate == DateTime.MinValue)
            {
                return string.Empty;
            }
            else
            {
                return strDate.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// [Fn_GetDrugReqStore]
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="intCode"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        //public decimal GetDrugReqStore(string intCode, string roomId)
        //{
        //    bool predicate(Rmstore x) => x.ItemId == intCode && x.RoomId == roomId;
        //    var stocknum = uow.Repo<RmstoreDto>().AsQueryable().ToList().
        //        Where(predicate).ToList().Sum(x => x.StockNum);
        //    return stocknum;
        //}




        /// <summary>
        /// Fn_GetTableVwHist
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="beginTime"></param>
        /// <returns></returns>
        public int GetTableVwHist(DateTime beginTime)
        {
            DateTime dtCurrentDateTime = _db.GetServerTime();
            var moveDayHist = _db.SysParam.GetByName<int>("MoveDayHist");

            if (dtCurrentDateTime.Day - beginTime.Day >= moveDayHist - 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// dbo.GetSexString
        /// </summary>
        /// <param name="sex"></param>
        /// <returns></returns>
        public string GetSexString(string sex)
        {
            if (sex == "M")
            {
                sex = "男";

            }
            else if (sex == "F")
            {
                sex = "女";

            }
            else if (sex == "O")
            {
                sex = "其他";

            }
            else if (sex == "男")
            {
                sex = "男";

            }
            else if (sex == "女")
            {
                sex = "女";
            }
            else
            {
                sex = "未知性别" + sex;
            }

            return sex;
        }

        /// <summary>
        /// Fn_StrMoney
        /// </summary>
        /// <param name="nhAmount"></param>
        /// <returns></returns>
        public string NumChangeToString(decimal nhAmount)
        {
            return string.Empty;
        }



        public static bool IsSendToCenterRoom(string usageId, int hospitalId)
        {
            var centerHospitalId = _db.SysParam.GetByName<int>("CenterHospitalId");
            bool isUseDropDrugCenterRoom = _db.SysParam.GetByName<bool>("IsUseDropDrugCenterRoom");
            if (centerHospitalId == hospitalId && isUseDropDrugCenterRoom && CheckSettingContainFormat("DropDrugCenterRoomUsageId", usageId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string TrimComer(string str)
        {
            if (str.StartsWith("，"))
            {
                return str.Substring(1);
            }
            return str;
        }



        /// <summary>
        /// 验证发票号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsInvoNo(string input)
        {
            string pattern = @"^[\d|\w|_]+$";
            return IsMatch(input, pattern);
        }

        #region 匹配方法
        /// <summary>
        /// 验证字符串是否匹配正则表达式描述的规则
        /// </summary>
        /// <param name="inputStr">待验证的字符串</param>
        /// <param name="patternStr">正则表达式字符串</param>
        /// <returns>是否匹配</returns>
        public static bool IsMatch(string inputStr, string patternStr)
        {
            return IsMatch(inputStr, patternStr, false, false);
        }

        ///// <summary>
        ///// 验证字符串是否匹配正则表达式描述的规则
        ///// </summary>
        ///// <param name="inputStr">待验证的字符串</param>
        ///// <param name="patternStr">正则表达式字符串</param>
        ///// <param name="ifIgnoreCase">匹配时是否不区分大小写</param>
        ///// <returns>是否匹配</returns>
        //public static bool IsMatch(string inputStr, string patternStr, bool ifIgnoreCase)
        //{
        //    return IsMatch(inputStr, patternStr, ifIgnoreCase, false);
        //}

        ///// <summary>
        ///// 验证字符串是否匹配正则表达式描述的规则
        ///// </summary>
        ///// <param name="inputStr">待验证的字符串</param>
        ///// <param name="patternStr">正则表达式字符串</param>
        ///// <param name="ifValidateWhiteSpace">是否验证空白字符串</param>
        ///// <returns>是否匹配</returns>
        //public static bool IsMatch(string inputStr, string patternStr, bool ifValidateWhiteSpace)
        //{
        //    return IsMatch(inputStr, patternStr, false, ifValidateWhiteSpace);
        //}

        /// <summary>
        /// 验证字符串是否匹配正则表达式描述的规则
        /// </summary>
        /// <param name="inputStr">待验证的字符串</param>
        /// <param name="patternStr">正则表达式字符串</param>
        /// <param name="ifIgnoreCase">匹配时是否不区分大小写</param>
        /// <param name="ifValidateWhiteSpace">是否验证空白字符串</param>
        /// <returns>是否匹配</returns>
        public static bool IsMatch(string inputStr, string patternStr, bool ifIgnoreCase, bool ifValidateWhiteSpace)
        {
            if (!ifValidateWhiteSpace && string.IsNullOrWhiteSpace(inputStr))
                return false;//如果不要求验证空白字符串而此时传入的待验证字符串为空白字符串，则不匹配
            Regex regex = null;
            if (ifIgnoreCase)
                regex = new Regex(patternStr, RegexOptions.IgnoreCase);//指定不区分大小写的匹配
            else
                regex = new Regex(patternStr);
            return regex.IsMatch(inputStr);
        }
        #endregion
    }
}


