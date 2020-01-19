using System;
using System.Collections.Generic;

namespace FinPay.DataAccess.Models
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public string Description { get; set; }

        public double  Amount { get; set; }

        public double CGST { get; set; }

        public double SGST { get; set; }

        public double TolatAmount { get; set; }


    }
}
