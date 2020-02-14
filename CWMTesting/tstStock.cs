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
    }

}
