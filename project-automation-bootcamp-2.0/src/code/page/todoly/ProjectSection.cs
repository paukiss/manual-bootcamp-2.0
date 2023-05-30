using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoly
{
    public class ProjectSection
    {
        public MenuProjectSection menuProjectSection = new MenuProjectSection();
        public Button addNewProjectButton = new Button(By.XPath("//td[text()='Add New Project']"));
        public TextBox nameProjectTxtBox = new TextBox(By.Id("NewProjNameInput"));
        public Button addButton = new Button(By.Id("NewProjNameButton"));
        public TextBox editProjectTxtBox = new TextBox(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        public Button saveButton = new Button(By.XPath("//td/div/img[@id='ItemEditSubmit']"));

        public ProjectSection() { }

        public void clickOnProject(string nameProject)
        {
            Label projectCreated = new Label(By.XPath("//td[text()='" + nameProject + "'] "));
            projectCreated.Click();
        }

        public bool isProjectDisplayedInList(string nameProject)
        {
            Label projectCreated = new Label(By.XPath("//td[text()='" + nameProject + "']"));
            return projectCreated.IsControlDisplayed();
        }

        public Label getProject(string nameProject)
        {
            Label projectCreated = new Label(By.XPath("//td[text()='" + nameProject + "']"));
            return projectCreated;
        }

        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            return nameProject.IsControlDisplayed();
        }
    }
}
