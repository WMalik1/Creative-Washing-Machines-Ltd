using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class TstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer customer = new clsCustomer();
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void Customer_idOK()
        {
            clsCustomer customer = new clsCustomer();
            Int32 testData = 1;
            customer.customer_id = testData;
            Assert.AreEqual(customer.customer_id, testData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "Hi";
            customer.name = testData;
            Assert.AreEqual(customer.name, testData);
        }


        [TestMethod]
        public void AddressOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "15 MadeUp Street, ImaginationVille";
            customer.address = testData;
            Assert.AreEqual(customer.address, testData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "a@a.com";
            customer.email = testData;
            Assert.AreEqual(customer.email, testData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "password";
            customer.password = testData;
            Assert.AreEqual(customer.password, testData);
        }

        [TestMethod]
        public void Marketing_emailsOK()
        {
            clsCustomer customer = new clsCustomer();
            bool testData = true;
            customer.marketing_emails = testData;
            Assert.AreEqual(customer.marketing_emails, testData);
        }

        [TestMethod]
        public void Registration_dateOK()
        {
            clsCustomer customer = new clsCustomer();
            DateTime testData = DateTime.Now.Date;
            customer.registration_date = testData;
            Assert.AreEqual(customer.registration_date, testData);
        }

    }
}
