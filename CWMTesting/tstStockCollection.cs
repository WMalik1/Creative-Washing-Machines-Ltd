using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CWMTesting
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.Clearence = true;
            TestItem.Description = "example";
            TestItem.Price = 9999.99;
            TestItem.Pristine = 12;
            TestItem.Non_Pristine = 15;
            TestItem.Next_Intake = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);

        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.Clearence = true;
            TestStock.Description = "example";
            TestStock.Price = 9999.99;
            TestStock.Pristine = 12;
            TestStock.Non_Pristine = 15;
            TestStock.Next_Intake = DateTime.Now.Date;

            AllStock.ThisStock = TestStock;

            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.Clearence = true;
            TestItem.Description = "example";
            TestItem.Price = 9999.99;
            TestItem.Pristine = 12;
            TestItem.Non_Pristine = 15;
            TestItem.Next_Intake = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

    }
}
