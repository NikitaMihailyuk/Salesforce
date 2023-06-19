using OpenQA.Selenium;
using SelesForce.Core.Selenium.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.PageObject
{
    public class NewAccountModal
    {
        Input accountName = new("Account Name");
        DropDown typeDropDown = new("Type");
        Button saveButton = new(By.XPath("//*[@title='Save']//button"));

        public void CreateAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select("Prospect");
            saveButton.GetElement().Click();
        }
    }
}