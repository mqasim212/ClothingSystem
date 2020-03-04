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
        public void PaymentIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.PaymentID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.PaymentID, TestData);
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

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnPayment.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.Date, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 12354;
            //assign the data to the property
            AnPayment.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.OrderID, TestData);
        }
        [TestMethod]
        public void StatusIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnPayment.StatusID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.StatusID, TestData);
        }
        [TestMethod]
        public void TotalCostPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 678;
            //assign the data to the property
            AnPayment.TotalCost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.TotalCost, TestData);
        }
    }
}
