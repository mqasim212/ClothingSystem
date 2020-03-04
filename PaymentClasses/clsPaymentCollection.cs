using System;
using System.Collections.Generic;

namespace PaymentClasses
{
    public class clsPaymentCollection
    {
       //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();
     
        public clsPayment ThisPayment { get; set; }

        //constructor for the class
        public clsPaymentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblPayment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank payment
                clsPayment AnPayment = new clsPayment();
                //read in the fields from the current record
                AnPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnPayment.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnPayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnPayment.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnPayment.TotalCost = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalCost"]);
                AnPayment.StatusID = Convert.ToBoolean(DB.DataTable.Rows[Index]["StatusID"]);
                //add the record to the private data member
                mPaymentList.Add(AnPayment);
                //point at the next record
                Index++;
            }
        }


        //public property for the payment list
        public List<clsPayment> PaymentList
        {
            get
            {
                //return the private data
                return mPaymentList;
            }

            set
            {
                //set the private data
                mPaymentList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
    }

 
   
      
  

}