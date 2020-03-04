using System.Collections.Generic;

namespace PaymentClasses
{
    public class clsPaymentCollection
    {
       //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();
     
        public clsPayment ThisPayment { get; set; }

        //constructor for the class


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