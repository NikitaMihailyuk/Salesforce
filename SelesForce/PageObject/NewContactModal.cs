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
    public class NewContactModal
    {
        Input accountName = new("Last Name");
        PartialTextDropDown typeDropDown = new("Account Name");
        static Faker Faker = new();

        Button saveButton = new(By.XPath("//*[@title='Save']//button"));

        public void CreateContact(string name, string listOption)
        {
            accountName.GetElement().SendKeys(Faker.Name.LastName());
            typeDropDown.Select("isthisnikita@gmail.com");
           // typeDropDown.SelectByPartText("Niki Niki");
            saveButton.GetElement().Click();
        }
    }
}