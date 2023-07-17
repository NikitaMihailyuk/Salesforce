using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Commons;
using NLog;
using NUnit.Allure.Attributes;
using SelesForce.Core;
using SelesForce.PageObject;

namespace SelesForce
{
    public class SalesForceTests : BaseTest
    {
        [Test(Description ="Failed coz random")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke")]
        [Description("Detailed Description")]
        [AllureOwner("Nikita")]
        [AllureSuite("Sales Force")]
        [AllureSubSuite("Sales Force - failed")]
        [AllureTms("TMS-16")]
        [AllureIssue("JIRA-14")]
        [AllureLink("https://google.com")]
        public void ErrorLogin()
        {
            var user = UserBuilder.GetRandomUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewAccountModal();
        }

        [Test]
        public void GoodLogin()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewAccountModal();
        }



        [Test]
        public void CreateAccount()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewAccountModal()
                .CreateAccount(user.Name, "Customer");
        }

        [Test]
        public void CreateContact()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user)
                .OpenNewContactModal()
                .CreateContact(user.Name, "Customer");
        }


        [Test]
        public void EditContact()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user).OpenExistingContactModal()
                .EditContact(user.Name, "Customer");
        }
        [Test]
        public void DeleteContact()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user).DeleteContact();
        }

        [Test]
        public void EditAccount()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user).OpenExistingAccountModal()
                .EditAccount(user.Name, "Customer");
        }
        [Test]
        public void DeleteAccount()
        {
            var user = UserBuilder.GetSalesForceUser();

            new LoginPage()
                .OpenPage()
                .Login(user).DeleteAccount();
        }
    }
}