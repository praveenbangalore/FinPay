using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace FinTechApi.Services.Interfaces
{
    public interface ITransactionsService
    {
        Transaction Get();

    }
}
