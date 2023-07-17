using OpenQA.Selenium;
using SelesForce.Core.Selenium.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.PageObject
{
    public class EditAccountModal
    {
        Input accountName = new("Account Name");
        Input accountNumber = new("Account Number");
        DropDown typeDropDown = new("Type");
        Button saveButton = new(By.XPath("//*[@title='Save']//button"));

        public void EditAccount(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select("Prospect");
            accountNumber.GetElement().SendKeys(listOption);
            saveButton.GetElement().Click();
        }
    }
}
