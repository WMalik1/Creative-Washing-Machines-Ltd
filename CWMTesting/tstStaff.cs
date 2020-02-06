using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
    }
}
