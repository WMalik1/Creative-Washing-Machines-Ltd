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

            TestItem.Product_Code = 1;
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

            TestStock.Product_Code = 1;
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

            TestItem.Product_Code = 1;
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

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Product_Code = 1;
            TestItem.Clearence = true;
            TestItem.Description = "AddMethodExample";
            TestItem.Price = 9999.99;
            TestItem.Pristine = 12;
            TestItem.Non_Pristine = 15;
            TestItem.Next_Intake = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.Product_Code = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Clearence = true;
            TestItem.Description = "AddMethodExample";
            TestItem.Price = 9999.99;
            TestItem.Pristine = 12;
            TestItem.Non_Pristine = 15;
            TestItem.Next_Intake = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.Product_Code = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        public void UpdateMethodOK()
        {
            clsStockCollection Allstock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            
            TestItem.Clearence = true;
            TestItem.Description = "AddMethodExample";
            TestItem.Price = 9999.99;
            TestItem.Pristine = 12;
            TestItem.Non_Pristine = 15;
            TestItem.Next_Intake = DateTime.Now.Date;

            Allstock.ThisStock = TestItem;

            PrimaryKey = Allstock.Add();

            TestItem.Product_Code = PrimaryKey;

            TestItem.Clearence = true;
            TestItem.Description = "AddMethodExampleChanged";
            TestItem.Price = 1234.99;
            TestItem.Pristine = 14;
            TestItem.Non_Pristine = 23;
            TestItem.Next_Intake = DateTime.Now.Date;

            Allstock.ThisStock = TestItem;

            Allstock.Update();

            Allstock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(Allstock.ThisStock, TestItem);

        }

    }
}
