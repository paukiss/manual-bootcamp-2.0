using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoly
{
    public class LoginSession
    {
        public TextBox emailTxtBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
        public TextBox passwordTxtBox = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
        public Button loginButton = new Button(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));

        public void login(string user, string pass) {
            emailTxtBox.SetText(user);
            passwordTxtBox.SetText(pass);
            loginButton.Click();
        }
    }
}
