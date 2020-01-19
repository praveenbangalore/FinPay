using FinTechAPI.Entities;
using FinTechAPI.Entities.Context;
using FinTechAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Services
{
    public class TransactionService : ITransactionService
    {
        private DataContext _context;
        public TransactionService(DataContext context)
        {
            _context = context;
        }

        public Transaction Get()
        {
            throw new NotImplementedException();
        }
    }
}
