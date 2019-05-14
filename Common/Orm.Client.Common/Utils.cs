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

        #region 
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

        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;

        }

        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }

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
    }
}
