using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinPay.DataAccess.Models
{
    public partial class FinPayContext : DbContext
    {
        public FinPayContext()
        {
        }

        public FinPayContext(DbContextOptions<FinPayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<PartnersMaster> PartnersMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= L505030; DataBase = FinPay; Trusted_Connection= True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InvoiceDesc).HasMaxLength(250);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PartnersMaster>(entity =>
            {
                entity.HasKey(e => e.PartnersId);

                entity.Property(e => e.PartnersId)
                    .HasColumnName("PartnersID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PartnersName)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
