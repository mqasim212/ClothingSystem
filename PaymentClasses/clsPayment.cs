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

        public string Valid(string OrderID, string Date, string TotalCost)
        {
            //Create a string variable to store the error message
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the OrderID is blank
            if (OrderID.Length == 0)
            {
                //record the error
                Error = Error + "The OrderID may not be blank : ";
            }
            //if the OrderID is 10 numbers or more
            if (OrderID.Length > 10)
            {
                //record the error
                Error = Error + "The OrderID may not be greater than 10 : ";
            }

            // **************************************************//
            //if the OrderID is blank
            if (TotalCost.Length == 0)
            {
                //record the error
                Error = Error + "The TotalCost may not be blank : ";

            }

            //if the TotalCost is 10 numbers or more
            if (TotalCost.Length > 10)
            {
                //record the error
                Error = Error + "The TotalCost may not be greater than 10";

            }

            try
            {

                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date Cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date Cannot be in the past : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "the date cannot be in the future : ";
            }
            //return any error messages
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

        //public string Valid(string orderID, string totalCost, string date)
        //{
        //    return "";
        //}
    }
}
