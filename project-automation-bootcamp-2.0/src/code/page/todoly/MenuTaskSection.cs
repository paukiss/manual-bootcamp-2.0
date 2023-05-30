using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoly
{
    public class MenuTaskSection
    {
        //public Button menuIconButton = new Button(By.XPath("//div[@id='ItemListPlaceHolder']//td[@class='ItemIndicator']"));
        public Button menuIconButton = new Button(By.XPath("(//ul[@id='mainItemList']//div[@class='ItemIndicator']/img)[last()]"));
        public Button editButton = new Button(By.XPath("//ul[@id='itemContextMenu']//a[text()='Edit']"));
        public Button deleteButton = new Button(By.Id("//ul[@id='itemContextMenu']//a[text()='Delete']"));
        public TextArea textEdit = new TextArea(By.Id("ItemEditTextbox"));
        public Button colorButton = new Button(By.XPath("//div[@id='Div1']/span[text()='2']"));
        public Button setDueDate = new Button(By.XPath("(//ul[@id='mainItemList']//div[text()='Set Due Date'])[last()]"));
    }
}
