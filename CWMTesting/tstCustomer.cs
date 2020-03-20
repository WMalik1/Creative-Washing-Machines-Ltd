using System;
using System.Linq;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class TstCustomer
    {
        string Name = "Joe,Bloggs";
        string Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
        string Email = "random.email@email.co.uk";
        string Password = "password";
        string Registration_date = DateTime.Now.Date.ToString();

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

            if (ACustomer.Registration_date.ToString("dd-MM-yyyy").Equals("20/03/2020"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameOneLessThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "a";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "a,b";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameOneMoreThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "ab,b";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameOneLessThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameOneMoreThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMidBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "aaaaaaaaaaaaa,aaaaaaaaaaaaa";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = String.Concat(Enumerable.Repeat('a', 48)) + ',' + String.Concat(Enumerable.Repeat('a', 49));
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameInvalidType()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "124236,j0+_-";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameNoSpace()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "JaredMarsh";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMultipleSpace()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Name = "Jared,,Marsh";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressOneLessThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "2 Random Street,RandomTown,RandomCounty";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "Apartment 2A,2 Random Street,RandomTown,RandomCounty,RN27FT,United Kingdom";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressOneMoreThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "Apartment 2A,Building Name,2 Random Street,RandomTown,RandomCounty,RN27FT,country";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMidBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "2 Random Street,RandomTown,RandomCounty,RN27FT,United Kingdom";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "2 Random Street,RandomTown,RandomCounty,RN27FT,United Kingdom,PaddingLine,PaddingLine,PaddingLine,PaddingLine,PaddingLine";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressInvalidType()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "2 %Random Street%,Random%%Town,RandomCounty,R%N27FT,Un%ited Kingdom";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLength()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Address = "";
            Address = Address.PadRight(251, 'a');
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailOneLessThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "12345";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "a@a.tk";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailOneMoreThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "a@a.com";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailOneLessThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 140)) + "@test.com";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 141)) + "@test.com";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailOneMoreThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 142)) + "@test.com";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMidBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 69)) + "@test.com";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 291)) + "@test.com";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailInvalidType()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Email = "Hello There";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = "";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordOneLessThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = "1234567";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = "12345678";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordOneMoreThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = "123456789";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordOneLessThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = String.Concat(Enumerable.Repeat('a', 29));
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = String.Concat(Enumerable.Repeat('a', 30));
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordOneMoreThanMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = String.Concat(Enumerable.Repeat('a', 31));
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMidBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = String.Concat(Enumerable.Repeat('a', 21));
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Password = String.Concat(Enumerable.Repeat('a', 100));
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Registration_date = DateTime.Now.Date.AddYears(-100).ToString();
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateOneLessThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Registration_date = DateTime.Now.Date.AddDays(-1).ToString();
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Registration_date = DateTime.Now.Date.ToString();
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateOneMoreThanMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Registration_date = DateTime.Now.Date.AddDays(1).ToString();
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Registration_date = DateTime.Now.Date.AddYears(100).ToString();
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateExtremeInvalidType()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            String Registration_date = "Invalid date";
            Error = ACustomer.Valid(Name, Address, Email, Password, Registration_date);
            Assert.AreNotEqual(Error, "");
        }

    }
}
