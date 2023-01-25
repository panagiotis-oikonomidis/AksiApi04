using AksiApi.Entities;
using AksiApi.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace AksiApi.Context
{
    public class AtaContext : DbContext
    {
        public AtaContext(DbContextOptions<AtaContext> options)
        : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }
    }
}
