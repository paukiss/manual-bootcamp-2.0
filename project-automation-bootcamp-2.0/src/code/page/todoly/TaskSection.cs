using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoly
{
    public class TaskSection
    {
        public TextBox inputTextTask = new TextBox(By.Id("NewItemContentInput"));
        public Button buttonAddTask = new Button(By.Id("NewItemAddButton"));

        public Boolean TaskNameIsDisplayed(String nameValue)
        {
            Label nameTask = new Label(By.XPath("(//ul[@id='mainItemList']/li//div[@class='ItemContentDiv' and text()='" + nameValue +"'])[last()]"));
            return nameTask.IsControlDisplayed();
        }

        public Boolean checkColorChange(String nameValue)
        {
            Label nameTask = new Label(By.XPath("(//ul[@id='mainItemList']/li//div[@class='ItemContentDiv' and @style='color: rgb(22, 139, 184); font-weight: bold;' and text()='" + nameValue + "'])[last()]"));
            return nameTask.IsControlDisplayed();
        }

        public void ClickTaskName(String nameValue)
        {
            Label nameTask = new Label(By.XPath("(//ul[@id='mainItemList']/li//div[@class='ItemContentDiv' and text()='" + nameValue + "'])[last()]"));
            nameTask.Click();
        }
    }
}
