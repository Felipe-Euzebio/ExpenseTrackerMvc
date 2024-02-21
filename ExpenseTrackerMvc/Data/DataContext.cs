using Microsoft.EntityFrameworkCore;
using ExpenseTrackerMvc.Models;

namespace ExpenseTrackerMvc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .Navigation(t => t.Category)
                .AutoInclude();

            base.OnModelCreating(modelBuilder);
        }
    }
}
