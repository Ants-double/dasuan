﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dasuan.web;
using UnitDasuanTest.beans;
using Newtonsoft.Json;
using dasuan;

namespace UnitDasuanTest
{
    /// <summary>
    /// AntsWeb 的摘要说明
    /// </summary>
    [TestClass]
    public class AntsWeb
    {
        public AntsWeb()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestAntsWebRequest()
        {
            string result = AntsWebRequest.getRequest("https://www.baidu.com/");
            LogExten.WriteLog();
            Console.WriteLine(result);

        }
        [TestMethod]
        public void TestpostRequest()
        {
            WindRawLidar wind = new WindRawLidar();
            wind.beginTime = "2019-01-01 16:20:11";
            wind.endTime = "2019-01-03 16:20:11";
            wind.insCode = "instrument";
            wind.scanType = "B0";
            wind.siteCode = "cgz";
            wind.timeInterval = 2;
            wind.ways = new List<string> { "hSpeed", "vSpeed", "direction" };
            string  jsonParam = JsonConvert.SerializeObject(wind);
            string result = AntsWebRequest.postRequest("http://192.168.15.168:8099/product/windlidar/requestExtractionRawWindData", jsonParam, true);
            Console.WriteLine(result);

        }
    }
}
