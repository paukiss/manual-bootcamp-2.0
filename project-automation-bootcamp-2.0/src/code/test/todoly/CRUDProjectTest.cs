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
    public class CRUDProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSession loginSession = new LoginSession();
        MenuSection menuSection = new MenuSection();
        ProjectSection projectSection = new ProjectSection();

        string user = "spaucara@bootcamp.com";
        string pass = "123456";


        [TestMethod]
        public void CRUDProject()
        {
            string projectCreated = "MOJIX";
            string projectUpdate = "QA";

            mainPage.loginLabel.Click();

            loginSession.emailTxtBox.SetText(user);
            loginSession.passwordTxtBox.SetText(pass);
            loginSession.loginButton.Click();
            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(), "Error! the login");

            projectSection.addNewProjectButton.Click();
            projectSection.nameProjectTxtBox.SetText(projectCreated);
            projectSection.addButton.Click();
            Assert.IsTrue(projectSection.isProjectDisplayedInList(projectCreated), "Error! Project was not created");

            projectSection.clickOnProject(projectCreated);
            projectSection.menuProjectSection.menuIconButton.Click();
            projectSection.menuProjectSection.editButton.Click();
            projectSection.editProjectTxtBox.SetText(projectUpdate);
            projectSection.saveButton.Click();
            Assert.IsTrue(projectSection.isProjectDisplayedInList(projectUpdate), "Error! Project was not updated");

            projectSection.clickOnProject(projectUpdate);
            projectSection.menuProjectSection.menuIconButton.Click();
            projectSection.menuProjectSection.deleteButton.Click();
            Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
            Assert.IsTrue(projectSection.ProjectNameIsDisplayed(projectUpdate), "Error! Project was not deleted");

        }
    }
}
