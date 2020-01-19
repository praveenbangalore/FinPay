
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinTechAPI.Entities.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
    }
}
