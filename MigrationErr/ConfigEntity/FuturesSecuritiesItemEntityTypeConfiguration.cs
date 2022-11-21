using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationErr.Models;

namespace MigrationErr.ConfigEntity
{
    public class FuturesSecuritiesItemEntityTypeConfiguration : IEntityTypeConfiguration<FuturesSecuritiesItem>
    {
        public void Configure(EntityTypeBuilder<FuturesSecuritiesItem> builder)
        {
            builder.HasKey(o => new { o.ClientCode, o.StockCode });

            builder.ToTable("TACC_FUTURESSECURITIES");

            builder.Property(p => p.StockCode).HasColumnType("VARCHAR2(20 CHAR)").HasColumnName("ASTOCKCODE");
            builder.Property(p => p.ClientCode).HasColumnType("VARCHAR2(10 CHAR)").HasMaxLength(10).HasColumnName("ACLIENTCODE");
            builder.Property(p => p.PendingBuy).HasColumnName("APENDINGBUY");
            builder.Property(p => p.PendingSell).HasColumnName("APENDINGSELL");
            builder.Property(p => p.MatchedBuyIntraday).HasColumnName("AMATCHEDBUYINTRADAY");
            builder.Property(p => p.MatchedSellIntraday).HasColumnName("AMATCHEDSELLINTRADAY");
            builder.Property(p => p.NetPosition).HasColumnName("ANETPOSITION");
            builder.Property(p => p.OpenPosition).HasColumnName("AOPENPOSITION");
            builder.Property(p => p.VMIntraday).HasColumnName("AVMINTRADAY");



        }
    }
}
