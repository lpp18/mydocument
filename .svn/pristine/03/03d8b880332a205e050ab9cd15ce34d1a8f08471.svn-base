using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ApplicationModel.Models
{
    public class Common
    {
        /// <summary>
        /// 获取WebConfig配置文件
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSetting(string key)
        {
            string Result = "";
            try
            {
                object obj = ConfigurationManager.AppSettings[key];
                Result = obj != null ? obj.ToString() : "";
            }
            catch (Exception ex)
            {
            }
            return Result;
        }
        /// <summary>
        /// 消息处理结果
        /// </summary>
        public  class ReturnMsg
        {
            public bool Result { get; set; }
            public string Message { get; set; }
            public string error { get; set; }
            public bool Success { get; set; }
            public bool Fail { get; set; }
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        public static bool CreateDir(string strPathName)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(strPathName);
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static string strLogPath = GetAppSetting("LogPath");
        public static string strErrLogPath = GetAppSetting("ErrorLogPath");

        /// <summary>
        /// 创建服务运行日志
        /// </summary>
        /// <param name="ServerName"></param>
        /// <returns></returns>
        public static string getLogFile(string ServerName)
        {
            if (strLogPath == "")
            {
                strLogPath = "C:\\ErrorLogPath";
                CreateDir(strLogPath);
            }
            CreateDir(strLogPath);
            return strLogPath + "\\Log_" + ServerName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        }
        /// <summary>
        /// 创建服务异常日志
        /// </summary>
        /// <param name="ServerName"></param>
        /// <returns></returns>
        public static string getErrorLogFile(string ServerName)
        {
            if (strErrLogPath == "")
            {
                strErrLogPath = "C:\\ServiceLog";
            }
            CreateDir(strErrLogPath);
            return strErrLogPath + "\\LogError_" + ServerName + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        }
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public string NowDateTime
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        /// <summary>
        /// 系统当前日期
        /// </summary>
        public string NowDate
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// 写日志文件
        /// </summary>
        /// <param name="sFileName"></param>
        /// <param name="sLogText"></param>
        public static void WriteLogFile(string sFileName, string sLogText)
        {
            StreamWriter logFile = new StreamWriter(sFileName, true);
            logFile.WriteLine(sLogText);
            logFile.Close();
        }
        /// <summary>
        /// 获取本机IP
        /// </summary>
        public static string GetHostIP()
        {
            string strHostIP = "";
            IPHostEntry oIPHost = Dns.Resolve(Environment.MachineName);
            if (oIPHost.AddressList.Length > 0)
                strHostIP = oIPHost.AddressList[0].ToString();
            return strHostIP;
        }
    }
}