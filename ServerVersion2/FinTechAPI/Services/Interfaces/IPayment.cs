using FinTechAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Services.Interfaces
{
    public interface IPaymentService
    {
        bool Process(int id);
        
    }
}
