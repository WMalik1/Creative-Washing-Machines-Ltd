using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CWMClasses;
using System.Collections.Generic;

namespace CWMTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);

        }

        [TestMethod]
        public void StaffPropertyOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestStaff = new clsStaff();

            TestStaff.staff_id = 1;
            TestStaff.Name = "Jake,Effa";
            TestStaff.Email = "effaj@gmail.com";
            TestStaff.Hire_Date = DateTime.Now.Date;
            TestStaff.Salary = 1000.00;
            TestStaff.Active = true;
            TestList.Add(TestStaff);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.staff_id = 1;
            TestStaff.Name = "Jake,Effa";
            TestStaff.Email = "effaj@gmail.com";
            TestStaff.Hire_Date = DateTime.Now.Date;
            TestStaff.Salary = 1000.00;
            TestStaff.Active = true;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);


        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestStaff = new clsStaff();

            TestStaff.staff_id = 1;
            TestStaff.Name = "Jake,Effa";
            TestStaff.Email = "effaj@gmail.com";
            TestStaff.Hire_Date = DateTime.Now.Date;
            TestStaff.Salary = 1000.00;
            TestStaff.Active = true;

            TestList.Add(TestStaff);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        
    }
}
