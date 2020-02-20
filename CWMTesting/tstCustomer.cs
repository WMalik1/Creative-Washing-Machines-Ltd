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
            customer.Customer_id = testData;
            Assert.AreEqual(customer.Customer_id, testData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "Hi";
            customer.Name = testData;
            Assert.AreEqual(customer.Name, testData);
        }


        [TestMethod]
        public void AddressOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "15 MadeUp Street, ImaginationVille";
            customer.Address = testData;
            Assert.AreEqual(customer.Address, testData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "a@a.com";
            customer.Email = testData;
            Assert.AreEqual(customer.Email, testData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            clsCustomer customer = new clsCustomer();
            string testData = "password";
            customer.Password = testData;
            Assert.AreEqual(customer.Password, testData);
        }

        [TestMethod]
        public void Marketing_emailsOK()
        {
            clsCustomer customer = new clsCustomer();
            bool testData = true;
            customer.Marketing_emails = testData;
            Assert.AreEqual(customer.Marketing_emails, testData);
        }

        [TestMethod]
        public void Registration_dateOK()
        {
            clsCustomer customer = new clsCustomer();
            DateTime testData = DateTime.Now.Date;
            customer.Registration_date = testData;
            Assert.AreEqual(customer.Registration_date, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Customer_id != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Name != "Joe,Bloggs")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Address != "2 Random Street,RandomTown,RandomCounty,RN27FT")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Email != "random.email@email.co.uk")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Password != "password")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMarketingEmailsFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Marketing_emails != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRegistrationDateFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);

            if (ACustomer.Registration_date.ToString("dd-MM-yyyy").Equals("20/02/2020"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }
}
