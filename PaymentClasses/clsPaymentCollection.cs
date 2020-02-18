using System.Collections.Generic;

namespace PaymentClasses
{
    public class clsPaymentCollection
    {
        public List<clsPayment> PaymentList { get; set; }
        public int Count { get; set; }
        public clsPayment ThisPayment { get; set; }
    }
}