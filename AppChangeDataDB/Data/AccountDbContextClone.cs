using AppChangeDataDB.EntityConfiguration;
using AppChangeDataDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AppChangeDataDB.Data
{
    public class AccountDbContextClone : DbContext
    {
        public DbSet<TradingFeeItem> TradingFeeItems { get; set; }
        public DbSet<TradingCash> TradingCashes { get; set; }

        public AccountDbContextClone(DbContextOptions<AccountDbContextClone> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TradingFeeItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TradingCashEntityTypeConfiguration());

        }
    }
}
