using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationErr.Models;

namespace MigrationErr.ConfigEntity
{
    public class TradingSecuritiesItemEntityTypeConfiguration : IEntityTypeConfiguration<TradingSecuritiesItem>
    {
        public void Configure(EntityTypeBuilder<TradingSecuritiesItem> builder)
        {
            builder.HasKey(o => new { o.ClientCode, o.StockCode });

            builder.ToTable("TACC_TRADINGSECURITIES");

            builder.Property(p => p.ClientCode).HasColumnType("VARCHAR2(10 CHAR)").HasColumnName("ACLIENTCODE");
            builder.Property(p => p.StockCode).HasColumnType("VARCHAR2(20 CHAR)").HasColumnName("ASTOCKCODE");

            builder.Property(p => p.TradingAvail).HasColumnName("ATRADINGAVAIL");
            builder.Property(p => p.TradingAvail_Mar).HasColumnName("ATRADINGAVAIL_MAR");
            builder.Property(p => p.PendingSell).HasColumnName("APENDINGSELL");
            builder.Property(p => p.PendingSell_Mar).HasColumnName("APENDINGSELL_MAR");
            builder.Property(p => p.MatchedSellIntraday).HasColumnName("AMATCHEDSELLINTRADAY");
            builder.Property(p => p.MatchedSellIntraday_Mar).HasColumnName("AMATCHEDSELLINTRADAY_MAR");
            builder.Property(p => p.Dividend).HasColumnName("ADIVIDEND");
            builder.Property(p => p.Restricted).HasColumnName("ARESTRICTED");
            builder.Property(p => p.MortgageAtBank).HasColumnName("AMORTGAGEATBANK");
            builder.Property(p => p.Holding).HasColumnName("AHOLDING");
            builder.Property(p => p.ESOP).HasColumnName("AESOP");
            builder.Property(p => p.MarproSuspend).HasColumnName("AMARPROSUSPEND");
            builder.Property(p => p.MatchedBuyIntraday).HasColumnName("AMATCHEDBUYINTRADAY");
            builder.Property(p => p.ReceivableT1).HasColumnName("ARECEIVABLE_T1");
            builder.Property(p => p.ReceivableT2).HasColumnName("ARECEIVABLE_T2");
            builder.Property(p => p.ReceivableRight).HasColumnName("ARECEIVABLE_RIGHT");
            builder.Property(p => p.RestrictedWaiting).HasColumnName("ARESTRICTEDWAITING");
            builder.Property(p => p.MortgageAtBankWaiting).HasColumnName("AMORTGAGEBANKWAITING");
            builder.Property(p => p.HoldingWaiting).HasColumnName("AHOLDINGWAITING");
            builder.Property(p => p.TradingWaiting).HasColumnName("ATRADINGWAITING");
            builder.Property(p => p.WaitingFromCustody).HasColumnName("AWAITINGFROMCUSTODY");
            builder.Property(p => p.ESOPWaiting).HasColumnName("AESOPWAITING");
            builder.Property(p => p.OddlotSellIntraday).HasColumnName("AODDLOTSELLINTRADAY");
        }
    }
}
