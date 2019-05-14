﻿using System;
using System.Text;
using System.Web;

namespace Orm.Utilities
{
    public class Logs
    {

        private static string logPath = string.Empty;
        /// <summary>  
        /// 保存日志的文件夹  
        /// </summary>  
        public static string LogPath
        {
            get
            {
                if (logPath == string.Empty)
                {
                    if (HttpContext.Current == null)
                    {
                        // Windows Forms 应用  
                        logPath = AppDomain.CurrentDomain.BaseDirectory;
                    }
                    else
                    {
                        // Web 应用  
                        logPath = AppDomain.CurrentDomain.BaseDirectory + @"FrameWork_Log/";
                    }
                }
                return logPath;
            }
            set { logPath = value; }
        }

        private static string logFielPrefix = string.Empty;
        /// <summary>  
        /// 日志文件前缀  
        /// </summary>  
        public static string LogFielPrefix
        {
            get { return logFielPrefix; }
            set { logFielPrefix = value; }
        }

        /// <summary>  
        /// 写日志  
        /// </summary>  
        public static void WriteLog(string logFile, string msg)
        {
            try
            {
                System.IO.StreamWriter sw = System.IO.File.AppendText(
                LogPath + LogFielPrefix + logFile + " " +
                DateTime.Now.ToString("yyyyMMdd") + ".Log"
                );
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") + "执行信息:");
                sb.Append(msg);
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                WriteLog(LogFile.Error, ex.ToString());
            }
        }

        /// <summary>  
        /// 写日志  
        /// </summary>  
        public static void WriteLog(LogFile logFile, string msg)
        {
            WriteLog(logFile.ToString(), msg);
        }
    }

    /// <summary>  
    /// 日志类型  
    /// </summary>  
    public enum LogFile
    {
        Trace,
        Warning,
        Error,
        SQL
    }
}
