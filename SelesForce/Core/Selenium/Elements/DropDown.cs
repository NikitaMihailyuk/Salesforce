using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.Core.Selenium.Elements
{

    public class DropDown : BaseElement
    {
        public DropDown(By locator) : base(locator)
        {
        }

        public DropDown(string locator) : base($"//label[text()='{locator}']/following-sibling::div//button")
        {
        }

        public void Select(string option)
        {
            WebDriver.FindElement(locator).Click();
            WebDriver.FindElement(By.XPath($"//*[@title='{option}']")).Click();
        }

    }
}