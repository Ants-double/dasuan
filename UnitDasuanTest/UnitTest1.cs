using System;
using System.Collections.Generic;
using dasuan.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitDasuanTest.beans;

namespace UnitDasuanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<WindRawLidar> windRawLidars = new List<WindRawLidar>();
            windRawLidars.Add(new WindRawLidar() { siteCode="001"});
            JsonHelper.WriteJson("test", windRawLidars);
        }
    }
}
