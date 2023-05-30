﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.test.todoly
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todo.ly/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
