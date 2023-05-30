using project_automation_bootcamp_2._0.src.code.page.todoly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.test.todoly
{
    [TestClass]
    public class CreateTask : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSession loginSession = new LoginSession();
        MenuSection menuSection = new MenuSection();
        ProjectSection projectSection = new ProjectSection();
        TaskSection taskSection = new TaskSection();

        string user = "spaucara@bootcamp.com";
        string pass = "123456";
        string nameProject = "Example Project";
        string newTask = "New task";

        [TestMethod]
        public void createTask()
        {
            mainPage.loginLabel.Click();

            loginSession.login(user, pass);
            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(), "Error! the login");

            projectSection.clickOnProject(nameProject);
            taskSection.inputTextTask.SetText(newTask);
            taskSection.buttonAddTask.Click();
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(newTask), "Error! Task was not created");
        }
    }
}
