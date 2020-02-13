using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentClasses;

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

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnPayment.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.Active, TestData);
        }
    }
}
