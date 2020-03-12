using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWMClasses;
using System.Collections.Generic;

namespace CWMTesting
{
    [TestClass]
    public class TstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Customer_id = 1;
            TestCustomer.Name = "Joe,Bloggs";
            TestCustomer.Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            TestCustomer.Email = "random.email@email.co.uk";
            TestCustomer.Password = "password";
            TestCustomer.Marketing_emails = true;
            TestCustomer.Registration_date = DateTime.Now.Date;

            TestList.Add(TestCustomer);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        } 

        [TestMethod]
        public void ThisCustomerOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Customer_id = 1;
            TestCustomer.Name = "Joe,Bloggs";
            TestCustomer.Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            TestCustomer.Email = "random.email@email.co.uk";
            TestCustomer.Password = "password";
            TestCustomer.Marketing_emails = true;
            TestCustomer.Registration_date = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Customer_id = 1;
            TestCustomer.Name = "Joe,Bloggs";
            TestCustomer.Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            TestCustomer.Email = "random.email@email.co.uk";
            TestCustomer.Password = "password";
            TestCustomer.Marketing_emails = true;
            TestCustomer.Registration_date = DateTime.Now.Date;

            TestList.Add(TestCustomer);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

    }
}
