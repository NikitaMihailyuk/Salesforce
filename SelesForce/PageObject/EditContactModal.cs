using Bogus.DataSets;
using Bogus;
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
        Button closeButton = new(By.XPath("//*[@title='Clear Selection']"));
        static Faker Faker = new();

        public void EditContact(string name, string listOption)
        {
            var contactName = Faker.Name.FullName();
            accountName.GetElement().Clear();
            accountName.GetElement().SendKeys(contactName);
            closeButton.GetElement().Click();
            typeDropDown.Select("isthisnikita@gmail.com");
            /// titleName.GetElement().SendKeys("124");
            saveButton.GetElement().Click();
        }
    }
}
