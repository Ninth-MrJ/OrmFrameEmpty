using System.Collections.Generic;
using System.Linq;
using Orm.Model;
using Orm.Model.Custom;

namespace Orm.Client.Common
{
    public class ToothsHelper
    {
        /// <summary>
        /// 根据牙位字符串解析成四个方位的字典集合信息（ToothPositionLT，ToothPositionLB，ToothPositionRT，ToothPositionRB）
        /// </summary>
        /// <param name="toothPositions"></param>
        /// <returns></returns>
        public static Dictionary<string,string> ParseCrossTooth(string toothPositions)
        {
            if (string.IsNullOrWhiteSpace(toothPositions))
            { 
                return null;
            }
            Dictionary<string,string> dic = new Dictionary<string,string>();
            List<string> lstTooths = toothPositions.Trim().Split(',').ToList();
            dic = ParseCrossTooth(lstTooths);

            return dic;
        }

        /// <summary>
        /// 根据牙位字符集合解析成四个方位的字典集合信息（ToothPositionLT，ToothPositionLB，ToothPositionRT，ToothPositionRB）
        /// </summary>
        /// <param name="lstTooths"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ParseCrossTooth(List<string> lstTooths)
        {
            if (lstTooths == null)
            { 
                return null;
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            List<string> lstToothLT = new List<string>();
            List<string> lstToothRT = new List<string>();
            List<string> lstToothRB = new List<string>();
            List<string> lstToothLB = new List<string>();
            if (lstTooths != null)
            {
                foreach (var toothNo in lstTooths)
                {
                    if (lstTooths.Contains(toothNo))
                    {
                        string s = toothNo;
                        if (s == "11" || s == "12" || s == "13" || s == "14" || s == "15" || s == "16" || s == "17" || s == "18")
                        { 
                            lstToothLT.Add(toothNo.Substring(1));
                        }
                        else if (s == "21" || s == "22" || s == "23" || s == "24" || s == "25" || s == "26" || s == "27" || s == "28")
                        { 
                            lstToothRT.Add(toothNo.Substring(1));
                        }
                        else if (s == "31" || s == "32" || s == "33" || s == "34" || s == "35" || s == "36" || s == "37" || s == "38")
                        { 
                            lstToothRB.Add(toothNo.Substring(1));
                        }
                        else if (s == "41" || s == "42" || s == "43" || s == "44" || s == "45" || s == "46" || s == "47" || s == "48")
                        { 
                            lstToothLB.Add(toothNo.Substring(1));
                        }
                    }

                }
            }

            dic.Add("ToothPositionLT", string.Join(",", lstToothLT.OrderBy(t => t)));
            dic.Add("ToothPositionLB", string.Join(",", lstToothLB.OrderBy(t => t)));
            dic.Add("ToothPositionRT", string.Join(",", lstToothRT.OrderBy(t => t)));
            dic.Add("ToothPositionRB", string.Join(",", lstToothRB.OrderBy(t => t)));

            return dic;
        }

       
        
    }
}
