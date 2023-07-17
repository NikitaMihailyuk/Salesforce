using OpenQA.Selenium;
using SelesForce.Core.Selenium.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.PageObject
{
    public class EditContactModal
    {
        Input accountName = new("Last Name");
        Input titleName = new("Title");
        PartialTextDropDown typeDropDown = new("Account Name");

        Button saveButton = new(By.XPath("//*[@title='Save']//button"));

        public void EditContact(string name, string listOption)
        {
            accountName.GetElement().Clear();
            accountName.GetElement().SendKeys(name);
            typeDropDown.Select("isthisnikita@gmail.com");
            ///  typeDropDown.SelectByPartText("Niki Niki");
            titleName.GetElement().SendKeys("124");
            saveButton.GetElement().Click();
        }
    }
}
