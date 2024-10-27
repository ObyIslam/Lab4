using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab4.Models;

namespace Lab4.Data
{
    public class Lab4Context : DbContext
    {
        public Lab4Context (DbContextOptions<Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<Lab4.Models.Categories> Category { get; set; } = default!;
        public DbSet<Lab4.Models.Products> Product { get; set; } = default!;
        public DbSet<Lab4.Models.Suppliers> Suppliers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the many-to-many relationship
            modelBuilder.Entity<Products>()
                .HasMany(p => p.Suppliers)
                .WithMany(s => s.Products)
                .UsingEntity(j => j.ToTable("ProductSuppliers"));
        }
    }
}
