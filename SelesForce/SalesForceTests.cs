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
    }
}