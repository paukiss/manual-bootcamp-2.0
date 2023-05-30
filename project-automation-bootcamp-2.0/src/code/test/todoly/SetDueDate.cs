using project_automation_bootcamp_2._0.src.code.page.todoly;
using project_automation_bootcamp_2._0.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.test.todoly
{
    [TestClass]
    public class SetDueDate : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSession loginSession = new LoginSession();
        MenuSection menuSection = new MenuSection();
        ProjectSection projectSection = new ProjectSection();
        TaskSection taskSection = new TaskSection();
        MenuTaskSection menuTask = new MenuTaskSection();

        string user = "spaucara@bootcamp.com";
        string pass = "123456";
        string nameProject = "Project Example";
        string newTask = "Task Example";
        string updateText = "Task Example";
        int day = 15;

        [TestMethod]
        public void setDueDate()
        {
            mainPage.loginLabel.Click();

            loginSession.login(user, pass);
            
            projectSection.clickOnProject(nameProject);
            taskSection.inputTextTask.SetText(newTask);
            taskSection.buttonAddTask.Click();
            
            taskSection.ClickTaskName(newTask);
            menuTask.setDueDate.Click();
            menuTask.date(day);
            menuTask.saveDueDate.Click();
            Assert.IsTrue(menuTask.textLabelDueDate.IsControlDisplayed(), "Error! Due date was not updated");

        }
    }
}
