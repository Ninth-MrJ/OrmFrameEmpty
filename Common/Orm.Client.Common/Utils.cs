using Newtonsoft.Json;
using Orm.Config;
using Orm.Framework.Services;
using Orm.Model;
using Orm.Model.Custom;
using Orm.Model.EnumDefine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;

namespace Orm.Client.Common
{
    /// <summary>
    /// �������ݵĲ���
    /// </summary>
    public class Utils : DBServiceBase
    {
        public static string ReadLocalRegitFile(string key)
        {
            KeyConfig loginUserConfig = ConfigManager<KeyConfig>.GetInfo(ConfigTypes.LocalRegit, key);
            if (loginUserConfig == null)
            {
                if (key.Contains("Is"))
                {
                    return "false";
                }
                else if (key.ToUpper().Contains("ID"))
                {
                    return "0";
                }
                else
                {
                    return string.Empty;
                }
            }
            string returnValue = loginUserConfig.KeyValue;
            if (key.Contains("Time") && Orm.Utilities.Common.IsNumeric(returnValue) && System.Convert.ToInt32(returnValue) < 15000)    //�����ʱ�����ã�����С��30��
            {
                return "15000";
            }
            else
            {
                return returnValue;
            }
        }
        /// <summary>
        /// ˢ�²�������棬���»�ȡָ��������ֵ��ͨ���ڶԲ����޸ĺ����
        /// </summary>
        /// <param name="key">������</param>
        public static void RefreshGblSetting(string key)
        {
            List<Model.GblSetting> lsts = null; //Orm.Config.Service.SystemService.SelectByKeyNum(key).ToList();
            if (lsts != null && lsts.Count > 0)
            {
                if (Global.LstGblSetting.FindAll(t => t.KeyNum == key).Count > 0)
                {
                    Global.LstGblSetting.Remove(Global.LstGblSetting.FindAll(t => t.KeyNum == key)[0]);
                }
                Global.LstGblSetting.Add(lsts[0]);
            }
        }
        //����
        public static string GetSystemSetting(string key)
        {
            if (key == "ReportTitleHeader")
            {
                return Orm.Config.UserProfiles.HospitalName;
                //List<Model.GblSetting> lsts = Orm.Config.Service.CommonServices.SelectByKeyNum("IsChain").ToList();
                //if (lsts != null && lsts.Count > 0 && lsts[0].SetValue == "1")
                //{
                //    return Orm.Config.UserProfiles.HospitalName;
                //}
            }
            List<Model.GblSetting> lst = Global.LstGblSetting.FindAll(t => t.KeyNum == key);
            if (lst == null || lst.Count == 0)
            {
                lst = null;// Orm.Config.Service.SystemService.SelectByKeyNum(key).ToList();
                //fwh �����ݿ�GblSetting ����key��

                if (lst != null && lst.Count > 0)
                {
                    Global.LstGblSetting.Add(lst[0]);
                    return GetKeyValue(lst[0]);
                }
                MessageBox.Show(string.Format("����{0}û�����ã�����ʧ�ܣ���֪ͨϵͳ����Ա��", key), "ϵͳ��ʾ", MessageBoxButton.OK, MessageBoxImage.Information);
                return string.Empty;
            }
            return GetKeyValue(lst[0]);
        }

        /// <summary>
        /// ˢ�²���ֵ
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void RefreshGblSetting(string key, string value)
        {
            if (Global.LstGblSetting.Find(t => t.KeyNum == key) != null)
            {
                Global.LstGblSetting.Find(t => t.KeyNum == key).SetValue = value;
            }
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSystemSettingEx(string key)
        {
            List<Model.GblSetting> lst = Global.LstGblSetting.FindAll(t => t.KeyNum == key);
            if (lst == null || lst.Count == 0)
            {
                lst = null;//Orm.Config.DBClientOuInRedis.SelectByKeyNum(key).ToList(); 
                if (lst != null && lst.Count > 0)
                {
                    Global.LstGblSetting.Add(lst[0]);
                    return GetKeyValue(lst[0]);
                }
                return string.Empty;
            }
            return GetKeyValue(lst[0]);
        }



        //����
        private static string GetKeyValue(Model.GblSetting infoGblSetting)
        {
            if (infoGblSetting.KeyNum.EndsWith("Id") && infoGblSetting.SetValue.Trim() == string.Empty)
            {
                return "0";
            }
            else
            {
                return infoGblSetting.SetValue;
            }
        }



        
        ////����
        //public static bool CheckSameLocBranch(int locationId1, int locationId2)
        //{
        //    var lstBsLocBranch1 = Service.DBClientService.GetList<Model.BsLocBranch>("HospitalID =@0", locationId1);
        //    var lstBsLocBranch2 = Service.DBClientService.GetList<Model.BsLocBranch>("HospitalID =@0", locationId2);
        //    foreach (var info2 in lstBsLocBranch2)
        //    {
        //        foreach (var info1 in lstBsLocBranch1)
        //        {
        //            if (info1.BranchId == info2.BranchId)
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        //����
        public static string GetLocalIP()
        {
            string strHostName = Dns.GetHostName(); //�õ�������������
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName); //ȡ�ñ���IP
            string strAddr = ipEntry.AddressList[0].ToString();
            return strAddr;
        }

        
       

       

        #region 

        private static char[] constant =
        {
        '0','1','2','3','4','5','6','7','8','9',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public static string GenerateRandom(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }
        #endregion

        #region �����4.0����˫��datagrid�ؼ���������
        //'DeferRefresh' is not allowed during an AddNew or EditItem transaction.
        public static bool IsUnderTabHeader(DependencyObject control)
        {
            if (control is System.Windows.Controls.TabItem)
            {
                return true;
            }

            DependencyObject parent = System.Windows.Media.VisualTreeHelper.GetParent(control);
            if (parent == null)
            {
                return false;
            }

            return IsUnderTabHeader(parent);
        }

        public static void CommitTables(DependencyObject control)
        {
            if (control is System.Windows.Controls.DataGrid)
            {
                System.Windows.Controls.DataGrid grid = control as System.Windows.Controls.DataGrid;
                grid.CommitEdit(System.Windows.Controls.DataGridEditingUnit.Row, true);
                return;
            }
            int childrenCount = System.Windows.Media.VisualTreeHelper.GetChildrenCount(control);
            for (int childIndex = 0; childIndex < childrenCount; childIndex++)
            {
                CommitTables(System.Windows.Media.VisualTreeHelper.GetChild(control, childIndex));
            }
        }

        #endregion     

        ///<summary>  
        ///��*.exe.config�ļ���appSettings���ý�����һ�Լ�ֵ��  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param>  
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            //��ȡ���򼯵������ļ�
            string assemblyConfigFile = Assembly.GetEntryAssembly().Location;
            System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(assemblyConfigFile);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(System.Configuration.ConfigurationSaveMode.Modified);
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }


        /// <summary>
        /// ����dataset  û��where����
        /// </summary>
        /// <param name="QueryString">��ѯ���</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string QueryString)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLDBConnection"].ConnectionString;
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(QueryString, connection);
            adapter.Fill(ds);
            return ds;
        }

        public static DataSet GetDataSet(string QueryString, SqlParameter[] prmArr)
        {
            return GetDataSet(QueryString, prmArr, CommandType.Text);
        }


        /// <summary>
        /// ���ݲ�ѯ���ȡ��DataSet�������ѯ���������������ⲿ�����������SQL���ʱ������ȫ��ִ��
        /// </summary>
        /// <param name="QueryString">��ѯ���</param>
        /// <param name="prmCol">SQL���Ĳ�������</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string QueryString, SqlParameter[] prmArr, CommandType cmdType)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLDBConnection"].ConnectionString;
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(QueryString, connection);
            adapter.SelectCommand.CommandType = cmdType;
            if (prmArr != null)
            {
                for (int i = 0; i < prmArr.GetLength(0); i++)
                {
                    adapter.SelectCommand.Parameters.Add(prmArr[i]);
                }
            }
            adapter.Fill(ds);
            return ds;
        }


        /// <summary>
        /// ��ȡ�����������ؽ��
        /// </summary>
        /// <param name="MachineID"></param>
        /// <returns></returns>
        public static DataTable GetCKMachineResult(string MachineID, string SampleNum, DateTime TestDate)
        {
            string sql = @"SELECT CKMachineResultDtl.result,CKMachineResult.MachineID,CKMachineResult.SampleNum,CKMachineResultDtl.ItemChannelNumber AS MajorName 
FROM CKMachineResult LEFT JOIN CKMachineResultDtl
ON CKMachineResult.id = CKMachineResultDtl.ResultID where CKMachineResult.MachineID = @MachineID and CKMachineResult.SampleNum=@SampleNum and CKMachineResult.TestDate>=@TestDate";
            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@MachineID", MachineID));
            parameter.Add(new SqlParameter("@SampleNum", SampleNum));
            parameter.Add(new SqlParameter("@TestDate", TestDate));
            return GetDataSet(sql, parameter.ToArray()).Tables[0];
        }
        /// <summary>
        /// ѹ������
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] input)
        {
            byte[] output;
            using (MemoryStream ms = new MemoryStream())
            {
                using (System.IO.Compression.GZipStream gs = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress))
                {
                    gs.Write(input, 0, input.Length);
                    gs.Close();
                    output = ms.ToArray();
                }
                ms.Close();
            }
            return output;
        }

    

        /// <summary>
        /// ���������л�ΪJSON��ʽ
        /// </summary>
        /// <param name="o">����</param>
        /// <returns>json�ַ���</returns>
        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;

        }

        /// <summary>
        /// ����JSON�������ɶ���ʵ�弯��
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <param name="json">json�����ַ���(eg.[{"ID":"112","Name":"ʯ�Ӷ�"}])</param>
        /// <returns>����ʵ�弯��</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }

        /// <summary>
        /// ����json��ʽ���ı�
        /// </summary>
        /// <param name="jsonStr">�����ı�</param>
        /// <param name="path">·��</param>
        public static void SaveJsonText(string jsonStr, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(jsonStr);
                    sw.Close();
                }
                fs.Close();
            }
        }



        

        /// <summary>
        /// ����ĳ����������Ե�ֵ�Ƿ����
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="last"></param>
        /// <param name="old"></param>
        /// <returns></returns>
        public static bool InfoIsChange<T>(T last, T old)
        {
            //OldInfoClone = usp;

            if (old != null && last != null)
            {
                foreach (System.Reflection.PropertyInfo p in old.GetType().GetProperties())
                {
                    foreach (System.Reflection.PropertyInfo q in last.GetType().GetProperties())
                    {
                        if (p.Name == q.Name/*&&p.Name!= "IsVIPPrice"*/)
                        {
                            var proInP = p.GetValue(last, null);
                            var proInQ = q.GetValue(old, null);
                            if (!object.Equals(proInP, proInQ))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

       

        public bool CheckSettingContainFormat(string keyNum, object item)
        {
            var gblSettingDto = this.GetAllList<GblSetting>().ToList();
            string keyValue = gblSettingDto.Where(z => z.KeyNum == keyNum).Single().SetValue;
            if (keyValue == string.Empty)
            {
                return true;
            }

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
    }

    public static class StringExtensions
    {
        /// <summary>
        ///ǰ��ȥ�ո��ܹ�����nullֵ��������Ϊnullֵʱ��תΪ�մ���
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string TrimEx(this string value)
        {
            if (value == null)
            {
                value = "";
            }

            return value = value.Trim();

        }
    }


}
