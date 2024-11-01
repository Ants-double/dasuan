using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasuan
{
    public class LogExten
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogExten));
        public static void WriteLog()
        {
            log.Info("大蒜日志模块正常！"); 
        }
    }
}
