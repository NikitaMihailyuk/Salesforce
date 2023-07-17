using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SelesForce.Core.Selenium.Elements
{
    public class DropDownMainPage : BaseElement
    {
        public DropDownMainPage(By locator) : base(locator)
        {
        }

        public DropDownMainPage(string locator) : base($"//*[@class='slds-icon_container slds-icon-utility-down'][{locator}]")
        {
        }

        public void Select(string option)
        {
            
            WebDriver.FindElement(locator).Click();
            WebDriver.FindElement(By.XPath($"//*[@title='{option}']")).Click();
        }

    }
}