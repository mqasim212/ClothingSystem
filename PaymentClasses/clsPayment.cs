using System;

namespace PaymentClasses
{
    public class clsPayment
    {
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public string OrderID { get; set; }
        public bool StatusID { get; set; }
        public string TotalCost { get; set; }
        public int PaymentID { get; set; }

        public Boolean Find(int primaryKey)
        {
            return false;
        }

      

        public string Valid(string OrderID, string TotalCost)
        {
            string Error = "";
            return Error;
        }
        
        }
    }
