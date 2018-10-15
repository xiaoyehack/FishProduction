using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace FishProduction
{
    public class LogHelper
    {
        #region static void WriteLog(Type t,Exception ex)
        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        #endregion

        #region static void WriteLog(Type t,string msg)
        public static void WriteLog(Type t, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error(msg);
        }

        #endregion
    }
}
