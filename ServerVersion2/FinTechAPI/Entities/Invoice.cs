using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string IssueDate { get; set; }
        public string Partner { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
