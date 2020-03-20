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
            TestCustomer.Marketing_emails = false;
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
            TestCustomer.Marketing_emails = false;
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
            TestCustomer.Marketing_emails = false;
            TestCustomer.Registration_date = DateTime.Now.Date;

            TestList.Add(TestCustomer);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            int PrimaryKey = 0;

            TestItem.Name = "Joe,Bloggs";
            TestItem.Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            TestItem.Email = "random.email@email.co.uk";
            TestItem.Password = "password";
            TestItem.Marketing_emails = false;
            TestItem.Registration_date = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.Customer_id = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

            AllCustomers.Delete();
        }
        
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            int PrimaryKey = 0;

            TestItem.Name = "Joe,Bloggs";
            TestItem.Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            TestItem.Email = "random.email@email.co.uk";
            TestItem.Password = "password";
            TestItem.Marketing_emails = false;
            TestItem.Registration_date = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.Customer_id = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            bool Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            int PrimaryKey = 0;

            TestItem.Name = "Joe,Bloggs";
            TestItem.Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            TestItem.Email = "random.email@email.co.uk";
            TestItem.Password = "password";
            TestItem.Marketing_emails = false;
            TestItem.Registration_date = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            
            TestItem.Customer_id = PrimaryKey;
            TestItem.Name = "Jane,Bloggs";
            TestItem.Address = "5 Random Street,RandomTown,RandomCounty,RN27FT";
            TestItem.Email = "random2.email@email.co.uk";
            TestItem.Password = "password2";
            TestItem.Marketing_emails = false;
            TestItem.Registration_date = DateTime.Now.Date.AddDays(1);

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

            AllCustomers.Delete();
        }

        [TestMethod]
        public void FilterByMarketingPreferenceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.FilterByMarketingPreference(false);
            Assert.AreEqual(1, FilteredCustomers.Count);
        }
        
        [TestMethod]
        public void FilterByAddressOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.FilterByAddress("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        
        [TestMethod]
        public void FilterByAddressNoneFound()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.FilterByAddress("TESTING");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByAddressTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            bool OK = true;
            FilteredCustomers.FilterByAddress("Random");

            if (FilteredCustomers.Count >= 1)
            {
                if (FilteredCustomers.CustomerList[0].Customer_id != 1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }
}
