using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelesForce.Core;
using SelesForce.PageObject;

namespace SelesForce
{
    public class SalesForceTests
    {



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