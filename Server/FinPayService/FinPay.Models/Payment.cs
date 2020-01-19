using System;
using System.Collections.Generic;
using System.Text;

namespace FinPay.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public decimal PayGetwayCharge { get; set; }
    }
}
