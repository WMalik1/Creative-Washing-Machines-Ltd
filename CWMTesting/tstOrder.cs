using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
	[TestClass]
	public class tstOrder
	{
		[TestMethod]
		public void InstanceOK()
		{
			clsOrder AnOrder = new clsOrder();
			Assert.IsNotNull(AnOrder);
		}

        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.OrderID = testData;
            Assert.AreEqual(AnOrder.OrderID, testData);
        }

        [TestMethod]
        public void customerIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder. customerID = testData;
            Assert.AreEqual(AnOrder.customerID, testData);
        }

        [TestMethod]
        public void staffIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.staffID = testData;
            Assert.AreEqual(AnOrder.staffID, testData);
        }
        
        [TestMethod]
        public void Product_codeOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.Product_code = testData;
            Assert.AreEqual(AnOrder.Product_code, testData);
        }

        [TestMethod]
        public void Total_costOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 testData = 1;
            AnOrder.Total_cost = testData;
            Assert.AreEqual(AnOrder.Total_cost, testData);
        }

        [TestMethod]
        public void Date_deliveryOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime testData = System.DateTime.Now.Date;
            AnOrder.Date_delivery = testData;
            Assert.AreEqual(AnOrder.Date_delivery, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correc
            Assert.IsTrue(Found);
        }

    }
}
