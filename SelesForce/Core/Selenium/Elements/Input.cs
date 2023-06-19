using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.Core.Selenium.Elements
{
    public class Input : BaseElement
    {
        public Input(By locator) : base(locator)
        {
        }

        public Input(string name) : base($"//label[text()='{name}']/following-sibling::div/input")
        {
        }
    }
}