using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class TSTReview
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
    }
}
