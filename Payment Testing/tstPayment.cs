using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentClasses;

namespace Payment_Testing
{
    [TestClass]
    public class tstPayment
    {
        //good test data
        //create sine test data to pass to the method
        string OrderID = "1234";
        string TotalCost = "45";
        string Date = DateTime.Now.Date.ToString();

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
            string TestData = "12354";
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
            string TestData = "678";
            //assign the data to the property
            AnPayment.TotalCost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.TotalCost, TestData);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "6";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "1";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxlessOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "123456789";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMax()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "1123456789";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMid()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "01234";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = "012345678999"; // this should fail
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string OrderID = ""; // this should fail
            OrderID = OrderID.PadRight(25, 'a'); //this should fail
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMinLessOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "0";
            //invoke the method
            Error = AnPayment.Valid(OrderID, TotalCost, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMin()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "a";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMinPlusOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "12";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMaxlessOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "123456789";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMax()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "1123456789";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMid()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "12345";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMaxPlusOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "123456789115"; // this should fail
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostExtremeMax()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create some Test data to pass the method
            string TotalCost = "abcdfsjkfdjfslkdjlkf"; // this should fail
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateExtremeMin()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //covert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMinLessOne()
        {
            //create a new instance of the payment class
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value
            string Date = "This is not a date!";
            //invoke the method
            Error = AnPayment.Valid(OrderID, Date, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}



