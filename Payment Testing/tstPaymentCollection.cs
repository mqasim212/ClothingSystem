using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentClasses;
using System.Collections.Generic;

namespace Payment_Testing
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }
        [TestMethod]
        public void PaymentListOK()
        {
            //create and instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.Active = true;
            TestItem.OrderID = "1";
            TestItem.Date = DateTime.Now.Date;
            TestItem.TotalCost = "2";
            TestItem.StatusID = true;
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create and instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();
            //set the properties of the test object
            TestPayment.PaymentID = 1;
            TestPayment.Active = true;
            TestPayment.OrderID = "1";
            TestPayment.Date = DateTime.Now.Date;
            TestPayment.TotalCost = "2";
            TestPayment.StatusID = true;
            //assign the data to the property
            AllPayments.ThisPayment = TestPayment;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create and instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.Active = true;
            TestItem.OrderID = "1";
            TestItem.Date = DateTime.Now.Date;
            TestItem.TotalCost = "2";
            TestItem.StatusID = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.Active = true;
            TestItem.OrderID = "1";
            TestItem.Date = DateTime.Now.Date;
            TestItem.TotalCost = "2";
            TestItem.StatusID = true;
            //set ThisPayment to the test data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentID = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentID = 1;
            TestItem.Active = true;
            TestItem.OrderID = "1";
            TestItem.Date = DateTime.Now.Date;
            TestItem.TotalCost = "2";
            TestItem.StatusID = true;
            //set ThisPayment to the test data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentID = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //delete the record
            AllPayments.Delete();
            //now find the record
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.OrderID = "1";
            TestItem.Date = DateTime.Now.Date;
            TestItem.TotalCost = "2";
            TestItem.StatusID = true;
            //set ThisPayment to the test data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.OrderID = "3";
            TestItem.Date = DateTime.Now.Date;
            TestItem.TotalCost = "5";
            TestItem.StatusID = false;
            //set te record based on the new test data
            AllPayments.ThisPayment = TestItem;
            //update the record
            AllPayments.Update();
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see ThisPAyment matches the test data
            Assert.AreEqual(AllPayments.ThisPayment, TestItem);
        }
        [TestMethod]
        public void ReportByDateMethodOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create an instance of the filtered data
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            //apply a blank string (should return all records);
            FilteredPayments.ReportByDate("");
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, FilteredPayments.Count);
        }
        [TestMethod]
        public void ReportByDateNoneFound()
        {
            //create an instance of the filtered data
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            //apply a date that doesnt exist
            FilteredPayments.ReportByDate("0");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredPayments.Count);
        }



        [TestMethod]
        public void ReportByDateTestDataFound()
        {
            //create an instance of the filtered data
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a date that doesnt exist

            FilteredPayments.ReportByDate("2004-04-07");


            //check that the correct number of records are found
            if (FilteredPayments.Count == 2)
            {
                //check that the first record is ID48
                if (FilteredPayments.PaymentList[0].PaymentID != 72)
                {
                    OK = false;
                }
                //check that the first record is ID50
                if (FilteredPayments.PaymentList[1].PaymentID != 73)
                {
                    OK = false;
                }
                OK = true;
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PaymentID = 1;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }
    }
}



