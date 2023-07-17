using OpenQA.Selenium;
using SelesForce.Core.Selenium.Elements;
using SelesForce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelesForce.PageObject
{
    public class LoginPage
    {
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Button loginButton = new("Login");

        private Button ContactTab = new(By.XPath("//*[@data-id='Contact']//span"));

        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.my.salesforce.com/");
            return this;
        }

        public LoginPage Login(UserModel user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();

            return this;
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public NewContactModal OpenNewContactModal()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));

            ContactTab.ClickElementViaJs();
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();

            return new NewContactModal();
        }

        public EditContactModal OpenExistingContactModal()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));
            DropDownMainPage DropDownNumber = new("1");
            DropDownNumber.Select("Edit");
            return new EditContactModal();
        }

        public void DeleteContact()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));
            DropDownMainPage DropDownNumber = new("1");
            DropDownNumber.Select("Delete");
            new Button(By.XPath("//*[@title='Delete']")).GetElement().Click();

        }
        public EditAccountModal OpenExistingAccountModal()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Account']//span"));
            DropDownMainPage DropDownNumber = new("1");
            DropDownNumber.Select("Edit");
            return new EditAccountModal();
        }

        public void DeleteAccount()
        {
            Browser.Instance.NavigateToUrl("https://d06000000zfpfeau-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Account']//span"));
            DropDownMainPage DropDownNumber = new("1");
            DropDownNumber.Select("Delete");
            new Button(By.XPath("//*[@title='Delete']")).GetElement().Click();

        }



    }
}