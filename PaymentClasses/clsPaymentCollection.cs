using System;
using System.Collections.Generic;

namespace PaymentClasses
{
    public class clsPaymentCollection
    {
       //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();
        //private data member thisPayment
        clsPayment mThisPayment = new clsPayment();

        //public clsPayment ThisPayment { get; set; }
        

        //constructor for the class
        public clsPaymentCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblPayment_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
        //public property for ThisPayment
        public clsPayment ThisPayment
        {
            get
            {
                //return the private data
                return mThisPayment;
            }
            set
            {
                //set the private data
                mThisPayment = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisPayment
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@Active", mThisPayment.Active);
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@Date", mThisPayment.Date);
            DB.AddParameter("@TotalCost", mThisPayment.TotalCost);
            DB.AddParameter("@StatusID", mThisPayment.StatusID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            //execute the stored proceedure
            DB.Execute("sproc_tblPayment_Delete");
        }

        public void Update()
        {
            //update an exisitng record based on the values of ThisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@Active", mThisPayment.Active);
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@Date", mThisPayment.Date);
            DB.AddParameter("@TotalCost", mThisPayment.TotalCost);
            DB.AddParameter("@StatusID", mThisPayment.StatusID);
            //execute the stored proceedure
            DB.Execute("sproc_tblPayment_Update");
        }

        public void ReportByDate(string Date)
        {
            //filters the records based on a full or partial Date
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the date parameter to the database
            DB.AddParameter("@Date", Date);
            //execute the stored proceedure
            DB.Execute("sproc_tblPayment_FilterByDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mPaymentList = new List<clsPayment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank payment
                clsPayment AnPayment = new clsPayment();
                //read in the fields from the current record
                AnPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnPayment.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnPayment.OrderID = Convert.ToString(DB.DataTable.Rows[Index]["OrderID"]);
                AnPayment.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnPayment.TotalCost = Convert.ToString(DB.DataTable.Rows[Index]["TotalCost"]);
                AnPayment.StatusID = Convert.ToBoolean(DB.DataTable.Rows[Index]["StatusID"]);
                //add the record to the private data member
                mPaymentList.Add(AnPayment);
                //point at the next record
                Index++;
            }
        }
    }
}