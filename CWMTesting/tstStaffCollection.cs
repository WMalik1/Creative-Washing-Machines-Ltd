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
            TestStaff.Name = "Steve,Harris";
            TestStaff.Email = "harris6@gmail.com";
            TestStaff.Hire_Date = DateTime.Now.Date;
            TestStaff.Salary = 7000.00;
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
            TestStaff.Name = "Steve,Harris";
            TestStaff.Email = "harris6@gmail.com";
            TestStaff.Hire_Date = DateTime.Now.Date;
            TestStaff.Salary = 7000.00;
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
            TestStaff.Name = "Steve,Harris";
            TestStaff.Email = "harris6@gmail.com";
            TestStaff.Hire_Date = DateTime.Now.Date;
            TestStaff.Salary = 7000.00;
            TestStaff.Active = true;

            TestList.Add(TestStaff);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.staff_id = 1;
            TestItem.Name = "Steve,Harris";
            TestItem.Email = "harris6@gmail.com";
            TestItem.Hire_Date = DateTime.Now.Date;
            TestItem.Salary = 7000.00;
            TestItem.Active = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staff_id = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

            AllStaff.Delete();

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;
            TestItem.staff_id = 1;
            TestItem.Name = "Steve,Harris";
            TestItem.Email = "harris6@gmail.com";
            TestItem.Hire_Date = DateTime.Now.Date;
            TestItem.Salary = 7000.00;
            TestItem.Active = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.staff_id = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);




        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;
            
            TestItem.Name = "Steve,Harris";
            TestItem.Email = "harris6@gmail.com";
            TestItem.Hire_Date = DateTime.Now.Date;
            TestItem.Salary = 7000.00;
            TestItem.Active = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.staff_id = PrimaryKey;
            TestItem.Name = "Alex,Eades";
            TestItem.Email = "alexe@gmail.com";
            TestItem.Hire_Date = DateTime.Now.Date;
            TestItem.Salary = 5000.00;
            TestItem.Active = false;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

            AllStaff.Delete();
        }


        [TestMethod]
        public void ReportByActiveOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.FilterByActive(true);
            Assert.AreEqual(5, FilteredStaff.Count);
        }

        [TestMethod]

        public void ReportByEmailMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByEmail("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        }
     

        [TestMethod]
        public void ReportByEmailTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean Ok = true;
            FilteredStaff.ReportByEmail("xxx xxx");

            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].staff_id != 4)
                {
                    Ok = false;
                }

                if (FilteredStaff.StaffList[1].staff_id != 5)
                {

                }
            }
            else
            {
                Ok = false;
            }

            Assert.IsTrue(Ok);
        }








    }
}
