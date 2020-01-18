using System;
using System.Collections.Generic;
using System.Text;
using FinPay.Engine;
using Microsoft.EntityFrameworkCore;

namespace FinPay.DataAccess
{
   public class FinPay:DbContext
   {
       public FinPay(DbContextOptions<FinPay> options): base(options) 
       {
           
       }
       //public DbSet<AccountInfo> AccountInfo { get; set; }
       //public DbSet<AccountInfo> AccountInfo { get; set; }


    }
}
