using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock stock = new clsStock();
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void Product_CodeOK()
        {
            clsStock stock = new clsStock();
            int testData = 1;
            stock.Product_Code = testData;
            Assert.AreEqual(stock.Product_Code, testData);

        }
        [TestMethod]
        public void DescriptionOK()
        {
            clsStock stock = new clsStock();
            String testData = "abcdefgjhjabcdefgjhjabcdefgjhjabcdefgjhjabcdefgjhjabcdefgjhjabcdefgjhjabcdefgjhj";
            stock.Description = testData;
            Assert.AreEqual(stock.Description, testData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsStock stock = new clsStock();
            double testData = int.MaxValue;
            stock.Price = testData;
            Assert.AreEqual(stock.Price, testData);
        }

        [TestMethod]
        public void PristineOK()
        {
            clsStock stock = new clsStock();
            int testData = int.MaxValue;
            stock.Pristine = testData;
            Assert.AreEqual(stock.Pristine, testData);
        }

        [TestMethod]
        public void Non_PristineOK()
        {
            clsStock stock = new clsStock();
            int testData = int.MaxValue;
            stock.Non_Pristine = testData;
            Assert.AreEqual(stock.Non_Pristine, testData);
        }

        [TestMethod]
        public void ClearenceOK()
        {
            clsStock stock = new clsStock();
            Boolean testData = true;
            stock.Clearence = testData;
            Assert.AreEqual(stock.Clearence, testData);
        }

        [TestMethod]
        public void Next_IntakeOK()
        {
            clsStock stock = new clsStock();
            DateTime testData = DateTime.Now.Date;
            stock.Next_Intake = testData;
            Assert.AreEqual(stock.Next_Intake, testData);
        }

        //-----------------------------------------------------

        [TestMethod]
        public void FindMethodOf()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Int32 ProductCode = 21;
            Found = stock.Find(ProductCode);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if (stock.Product_Code != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if ((String) stock.Description != "Samsung Series 4")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PriceNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if (stock.Price != 1299.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PristineNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if (stock.Pristine != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Non_PristineNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if (stock.Non_Pristine != 15)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ClearenceNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if (stock.Clearence != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Next_IntakeNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 21;
            Found = stock.Find(Product_Code);
            if (stock.Next_Intake != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }

}
