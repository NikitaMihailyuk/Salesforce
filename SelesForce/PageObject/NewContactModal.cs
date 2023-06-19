using OpenQA.Selenium;
using SelesForce.Core.Selenium.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.PageObject
{
    public class NewContactModal
    {
        Input accountName = new("Last Name");
        PartialTextDropDown typeDropDown = new("Account Name");

        Button saveButton = new(By.XPath("//*[@title='Save']//button"));

        public void CreateContact(string name, string listOption)
        {
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select("nymikha6@gmail.com");
            typeDropDown.Clear();
            typeDropDown.SelectByPartText("adfg");

            saveButton.GetElement().Click();
        }
    }
}