﻿using System;
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
        public void CountPropertyOK()
        {
            //create and instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 10;
            //assign the data to the property
            AllPayments.Count = SomeCount;
            //test to see the two values are the same
            Assert.AreEqual(AllPayments.Count, SomeCount);
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
    } 
}



