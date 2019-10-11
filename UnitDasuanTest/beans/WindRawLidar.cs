using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitDasuanTest.beans
{
    class WindRawLidar
    {

        public String siteCode { get; set; }

        public String insCode { get; set; }
        //开始时间
        public String beginTime { get; set; }
        //结束时间
        public String endTime { get; set; }
        //扫描类型
        public String scanType { get; set; }

        public List<String> ways { get; set; }

        public int timeInterval { get; set; }
    }
}
