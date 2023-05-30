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
    public class ChangeColor : TestBase
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

        [TestMethod]
        public void changeColor()
        {
            mainPage.loginLabel.Click();

            loginSession.login(user, pass);
            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(), "Error! the login");

            projectSection.clickOnProject(nameProject);
            taskSection.inputTextTask.SetText(newTask);
            taskSection.buttonAddTask.Click();
            
            taskSection.ClickTaskName(newTask);
            menuTask.colorButton.Click();

            Assert.IsTrue(taskSection.checkColorChange(updateText), "Error! Task was not updated");


        }
    }
}
