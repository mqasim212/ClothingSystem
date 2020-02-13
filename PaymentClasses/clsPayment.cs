using System;

namespace PaymentClasses
{
    public class clsPayment
    {
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public int OrderID { get; set; }
        public bool StatusID { get; set; }
        public int TotalCost { get; set; }
    }
}