using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class tstStaff
    {
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
            string testData = "Jake Effa";
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

            if (AStaff.Name != "Jake Effa")
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

    }
}