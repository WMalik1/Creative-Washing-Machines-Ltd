using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class tstStock
    {

        
        string Description = "abcdefg";
        string Price = "23.99";
        string Pristine = "23";
        string Non_Pristine = "12";
        string Next_Intake = DateTime.Now.Date.ToString();

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
            Int32 ProductCode = 23;
            Found = stock.Find(ProductCode);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNotFound()
        {
            clsStock stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Code = 23;
            Found = stock.Find(Product_Code);
            if (stock.Product_Code != 23)
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
            Int32 Product_Code = 23;
            Found = stock.Find(Product_Code);
            if ((String) stock.Description != "Example")
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
            Int32 Product_Code = 23;
            Found = stock.Find(Product_Code);
            if (stock.Price != 9999.99)
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
            Int32 Product_Code = 23;
            Found = stock.Find(Product_Code);
            if (stock.Pristine != 13)
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
            Int32 Product_Code = 23;
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
            Int32 Product_Code = 23;
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
            Int32 Product_Code = 23;
            Found = stock.Find(Product_Code);
            if (stock.Next_Intake.Equals("20/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock stock = new clsStock();
            String Error = "";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        //----------------------------------------------------------------
        // Testing for Description.

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "akjhkuhkuhiuh";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "ab";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyza";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzab";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabc";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "abcdefghijklmnopqrstuvwxyzabcdefghijklmn";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Description = "";
            Description = Description.PadRight(100, 'a');
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------------------
        // Testing for Price.

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Price = Decimal.MinValue.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Decimal PriceMin = 0;
            PriceMin = PriceMin - (Decimal)0.01;
            string Price = PriceMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Decimal PriceMin = 0;
            string Price = PriceMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Decimal PriceMin = 0;
            PriceMin = PriceMin + (Decimal)0.01;
            string Price = PriceMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Decimal PriceMax = Decimal.MaxValue;
            PriceMax = PriceMax - (Decimal)0.01;
            string Price = PriceMax.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Decimal PriceMax = Decimal.MaxValue;
            string Price = PriceMax.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Decimal PriceMax = Decimal.MaxValue;
            Decimal PriceMid = PriceMax/2;
            string Price = PriceMid.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Price = "This is not a date";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------------------
        // Testing for Pristine.

        [TestMethod]
        public void PristineExtremeMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int PristineExtremeMin = int.MinValue;
            string Pristine = PristineExtremeMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PristineMinLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int PristineMinLessOne = 0 - 1;
            string Pristine = PristineMinLessOne.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PristineMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int PristineMin = int.MinValue;
            string Pristine = PristineMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PristineMinPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int PristineMinPlusOne = 0 + 1;
            string Pristine = PristineMinPlusOne.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PristineMaxLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int PristineMaxLessOne = int.MaxValue - 1;
            string Pristine = PristineMaxLessOne.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PristineMid()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int PristineMid = int.MaxValue / 2;
            string Pristine = PristineMid.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PristineInvalidData()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Pristine = "This is not a valid pristine value";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------------------
        // Testing for Non_Pristine.

        [TestMethod]
        public void Non_PristineExtremeMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int Non_PristineExtremeMin = int.MinValue;
            string Non_Pristine = Non_PristineExtremeMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Non_PristineMinLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int Non_PristineMinLessOne = 0 - 1;
            string Non_Pristine = Non_PristineMinLessOne.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Non_PristineMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int Non_PristineMin = int.MinValue;
            string Non_Pristine = Non_PristineMin.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Non_PristineMinPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int Non_PristineMinPlusOne = 0 + 1;
            string Non_Pristine = Non_PristineMinPlusOne.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Non_PristineMaxLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int Non_PristineMaxLessOne = int.MaxValue - 1;
            string Non_Pristine = Non_PristineMaxLessOne.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Non_PristineMid()
        {
            clsStock stock = new clsStock();
            string Error = "";
            int Non_PristineMid = int.MaxValue / 2;
            string Non_Pristine = Non_PristineMid.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Non_PristineInvalidData()
        {
            clsStock stock = new clsStock();
            string Error = "";
            string Non_Pristine = "This is not a valid pristine value";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------------------
        // Testing for Next_Intake. 
        [TestMethod]
        public void Next_IntakeExtremeMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-2);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMinLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMin()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMinPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMaxLessOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(2);
            TestDate = TestDate.AddDays(-1);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMax()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(2);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMaxPlusOne()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(2);
            TestDate = TestDate.AddDays(1);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeMid()
        {
            clsStock stock = new clsStock();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string Next_Intake = TestDate.ToString();
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Next_IntakeInvalidData()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string Next_Intake = "This is not a date";
            Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);
            Assert.AreNotEqual(Error, "");
        }

    }

    }

