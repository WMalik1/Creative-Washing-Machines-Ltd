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
	}
}
