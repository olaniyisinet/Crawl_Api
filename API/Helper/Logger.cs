using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace API.Helper
{
    public static class Logger
    {
        private static readonly ILog _errorLogger = LogManager.GetLogger("ErrorFile");
        private static readonly ILog _activityLogger = LogManager.GetLogger("ActivityFile");

        public static string LogError(string user, string error)
        {
            try
            {
                _errorLogger.Error(user + "    :    " + DateTime.Now + "     :   " + error + "\n\n");
                return "Logged";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string LogActivity(string user, string activity)
        {
            try
            {
                _errorLogger.Info(user + "    :    " + DateTime.Now + "     :   " + activity + "\n\n");
                return "Logged";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}