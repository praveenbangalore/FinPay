using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public string Amount { get; set; }
        public string TransactionId { get; set; }
    }
}
