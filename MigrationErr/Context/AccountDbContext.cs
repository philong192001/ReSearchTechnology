using Microsoft.EntityFrameworkCore;
using MigrationErr.ConfigEntity;
using MigrationErr.Models;

namespace MigrationErr.Context
{
    public class AccountDbContext : DbContext
    {

        //CKPS
        //public DbSet<FuturesBalance> FuturesBalances { get; set; }
        public virtual DbSet<FuturesCash> FuturesCashes { get; set; }
        public virtual DbSet<FuturesSecuritiesItem> FuturesSecuritiesItems { get; set; }

        //CKCS
        //public DbSet<TradingBalance> TradingBalances { get; set; }
        public virtual DbSet<TradingCash> TradingCashes { get; set; }
        public virtual DbSet<TradingSecuritiesItem> TradingSecuritiesItems { get; set; }
        public virtual DbSet<TradingFeeItem> TradingFeeItems { get; set; }

        //Log
        public virtual DbSet<CashLog> CashLogs { get; set; }
        public virtual DbSet<SecuritiesLog> SecuritiesLogs { get; set; }

        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
            // _mediator = mediator;
        }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fu
            //modelBuilder.ApplyConfiguration(new FuturesBalanceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FuturesSecuritiesItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FuturesCashEntityTypeConfiguration());

            //CKCS
            //modelBuilder.ApplyConfiguration(new TradingBalanceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TradingCashEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TradingSecuritiesItemEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TradingFeeItemEntityTypeConfiguration());

            //LOG
            modelBuilder.ApplyConfiguration(new CashLogEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SecuritiesLogEntityTypeConfiguration());
        }

    }
}
