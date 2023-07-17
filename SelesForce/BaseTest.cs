﻿using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SelesForce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        private AllureLifecycle allure;

        [OneTimeSetUp]
        public void SetUp()
        {
            allure = AllureLifecycle.Instance;

        }
        [TearDown]
        public void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status==TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
                byte[] bytes = screenshot.AsByteArray;
                allure.AddAttachment("Screenshot", "image/png", bytes);
            }
            Browser.Instance.CloseBrowser();
        }
    }
}