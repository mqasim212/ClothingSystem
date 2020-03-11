using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PaymentClasses
{
    public class clsPayment
    {
        //private data member for the paymentID property
        private Int32 mPaymentID;
        private string mOrderID;
        private string mTotalCost;
        private DateTime mDate;
        private Boolean mStatusID;
        private Boolean mActive;
        public bool Find(int PaymentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PaymentID to search for
            DB.AddParameter("@PaymentID", PaymentID);
            //execute the stored proceedure
            DB.Execute("sproc_tblPayment_FilterByPaymentID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //set the private data member to the test value
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["OrderID"]);
                mTotalCost = Convert.ToString(DB.DataTable.Rows[0]["TotalCost"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mStatusID = Convert.ToBoolean(DB.DataTable.Rows[0]["StatusID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }



        public string Valid(string OrderID, string TotalCost)
        {
            string Error = "";
            return Error;
        }
        //public property for the paymentID
        public int PaymentID
        {
            get
            {
                //return the private data
                return mPaymentID;
            }
            set
            {
                //set the value of the private data member
                mPaymentID = value;
            }
        }

        //public property for the OrderId
        public string OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }
        //public property for the Total Cost
        public string TotalCost
        {
            get
            {
                //return the private data
                return mTotalCost;
            }
            set
            {
                //set the value of the private data member
                mTotalCost = value;
            }
        }
        //public property for Date
        public DateTime Date
        {
            get
            {
                //return the private data
                return mDate;
            }
            set
            {
                //set the private data
                mDate = value;
            }
        }
        //public property for StatusId
        public bool StatusID
        {
            get
            {
                //return the private data
                return mStatusID;
            }
            set
            {
                //set the private data
                mStatusID = value;
            }
        }

        //public property for Active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
    }
}
