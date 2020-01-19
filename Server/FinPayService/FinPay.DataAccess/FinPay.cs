using System;
using System.Collections.Generic;
using System.Text;
using FinPay.Models;
using Microsoft.EntityFrameworkCore;

namespace FinPay.DataAccess
{
   public class FinPay:DbContext
   {
       public FinPay(DbContextOptions<FinPay> options): base(options) 
       {
           
       }
        //public DbSet<AccountInfo> AccountInfo { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Login> Login { get; set; }


    }
}
