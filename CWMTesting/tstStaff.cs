using System;
using System.Linq;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class tstStaff
    {

        string Name = "Jake,Effa";
        string Email = "effaj@gmail.com";
        string Hire_Date = DateTime.Now.Date.ToString();
        string Salary = "1000.00";







        [TestMethod]
        public void InstanceOk()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void Staff_idOK()
        {
            clsStaff staff = new clsStaff();
            Int32 testData = 1;
            staff.staff_id = testData;
            Assert.AreEqual(staff.staff_id, testData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsStaff staff = new clsStaff();
            string testData = "Jake,Effa";
            staff.Name = testData;
            Assert.AreEqual(staff.Name, testData);
        }

        [TestMethod]
        public void Email_addressOK()
        {
            clsStaff staff = new clsStaff();
            string testData = "a@a.com";
            staff.Email = testData;
            Assert.AreEqual(staff.Email, testData);
        }

        [TestMethod]
        public void ActiveOK()
        {
            clsStaff staff = new clsStaff();
            bool testData = true;
            staff.Active = testData;
            Assert.AreEqual(staff.Active, testData);
        }

        [TestMethod]
        public void SalaryOK()
        {
            clsStaff staff = new clsStaff();
            double testData = int.MaxValue;
            staff.Salary = testData;
            Assert.AreEqual(staff.Salary, testData);
        }


        [TestMethod]
        public void Hire_DateOK()
        {
            clsStaff staff = new clsStaff();
            DateTime testData = DateTime.Now.Date;
            staff.Hire_Date = testData;
            Assert.AreEqual(staff.Hire_Date, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);

            if (AStaff.staff_id != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);

            if (AStaff.Name != "Jake,Effa")
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);

            if (AStaff.Email != "effaj@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);

            if (AStaff.Active != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);

            if (AStaff.Hire_Date.ToString("dd-MM-yyyy").Equals("07/08/2012"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staff_id = 1;
            Found = AStaff.Find(staff_id);

            if (AStaff.Salary != 4000.00)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        
        }

        [TestMethod]

        public void NameExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void NameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void NameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "a,b";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "ab,b";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMax()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void NameMaxPlusOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void NameMid()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Name = "aaaaaaaaaaaaa,aaaaaaaaaaaaa";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameInvalidData()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Name = "124236,j0+_-";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]

        public void NameExtremeMax()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Name = String.Concat(Enumerable.Repeat('a', 48)) + ',' + String.Concat(Enumerable.Repeat('a', 49));
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void EmailExtremeMin()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = "";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]

        public void EmailMinLessOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = "12345";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void EmailMin()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = "a@a.tk";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void EmailMinPlusOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = "a@a.com";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void EmailMaxLessOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 140)) + "@test.com";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void EmailMax()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 141)) + "@test.com";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void EmailMaxPlusOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 142)) + "@test.com";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void EmailMid()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 69)) + "@test.com";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void EmailExtremeMax()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = String.Concat(Enumerable.Repeat('a', 291)) + "@test.com";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void EmailInvalidData()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Email = "Hello There";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void HireDateExtremeMin()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Hire_Date = DateTime.Now.Date.AddYears(-100).ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void HireDateMinLessOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Hire_Date = DateTime.Now.Date.AddDays(-1).ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void HireDateMin()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Hire_Datee = DateTime.Now.Date.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void HireDateMinPlusOne()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Hire_Date = DateTime.Now.Date.AddDays(1).ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void HireDateExtremeMax()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Hire_Date = DateTime.Now.Date.AddYears(100).ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void HireDateInvalidData()

        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Hire_Date = "Invalid date";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void SalaryExtremeMin()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Salary = Decimal.MinValue.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void SalaryMinLessOne()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            Decimal SalaryMin = 0;
            SalaryMin = SalaryMin - (Decimal)0.01;
            string Salary = SalaryMin.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void SalaryMin()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            Decimal SalaryMin = 0;
            string Salary = SalaryMin.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");

        }



        [TestMethod]

        public void SalaryMinPlusOne()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            Decimal SalaryMin = 0;
            SalaryMin = SalaryMin + (Decimal)0.01;
            string Salary = SalaryMin.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void SalaryMaxLessOne()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            Decimal SalaryMax = Decimal.MaxValue;
            SalaryMax = SalaryMax - (Decimal)0.01;
            string Salary = SalaryMax.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void SalaryMax()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            Decimal SalaryMax = Decimal.MaxValue;
            string Salary = SalaryMax.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void SalaryMid()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            Decimal SalaryMax = Decimal.MaxValue;
            Decimal SalaryMid = SalaryMax / 2;
            string Salary = SalaryMid.ToString();
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void SalaryInvalidData()

        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Salary = "This is not a date";
            Error = AStaff.Valid(Name, Email, Hire_Date, Salary);
        }





    }

}
  