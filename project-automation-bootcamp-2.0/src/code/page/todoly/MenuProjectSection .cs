using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoly
{
    public class MenuProjectSection
    {
        public Button menuIconButton = new Button(By.XPath("//div[contains(@style,'block')]/img"));
        public Button editButton = new Button(By.XPath("//ul[@id=\"projectContextMenu\"]//a[text()='Edit']"));
        public Button deleteButton = new Button(By.Id("ProjShareMenuDel"));
    }
}
