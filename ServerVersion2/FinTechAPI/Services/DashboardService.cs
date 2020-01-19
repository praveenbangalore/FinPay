using FinTechAPI.Entities;
using FinTechAPI.Entities.Context;
using FinTechAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Services
{
    public class DashboardService : IDashboardService
    {
        private DataContext _context;
        public DashboardService(DataContext context)
        {
            _context = context;
        }

        public Dashboard Get()
        {
            throw new NotImplementedException();
        }
    }
}
