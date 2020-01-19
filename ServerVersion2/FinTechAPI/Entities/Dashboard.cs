using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Entities
{
   
    public class Dashboard
    {
        public int Id { get; set; }
        public int TotalInvoices { get; set; }
        public int TotalPayment { get; set; }
        public int PaymentFailed { get; set; }
        public int TotalResponse { get; set; }
    }
}
