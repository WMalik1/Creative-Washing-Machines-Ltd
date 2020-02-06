using System;
using CWMClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWMTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
    }
}
