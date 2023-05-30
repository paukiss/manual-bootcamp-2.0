using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoly
{
    public class MainPage
    {
        public Label loginLabel = new Label(By.XPath("//img[contains(@src,'pagelogin')]"));
    }
}
