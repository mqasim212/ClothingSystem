using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payment_Testing
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(AnPayment);
        }
    }
}
