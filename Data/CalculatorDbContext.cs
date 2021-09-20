using Calculator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Data
{
    public class CalculatorDbContext : DbContext
    {
        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<History>().Property(e => e.FirstNumber).HasPrecision(28, 20);
            modelBuilder.Entity<History>().Property(e => e.SecondNumber).HasPrecision(28, 20);
            modelBuilder.Entity<History>().Property(e => e.Result).HasPrecision(28, 20);
            modelBuilder.Entity<History>();


        }
        public DbSet<History> History { get; set; }
    }
}
