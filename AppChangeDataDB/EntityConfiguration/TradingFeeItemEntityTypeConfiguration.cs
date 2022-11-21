using AppChangeDataDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppChangeDataDB.EntityConfiguration
{
    public class TradingFeeItemEntityTypeConfiguration : IEntityTypeConfiguration<TradingFeeItem>
    {
        public void Configure(EntityTypeBuilder<TradingFeeItem> builder)
        {
            builder.HasKey(o => new { o.ClientCode, o.FeeType });
            builder.ToTable("TACC_TRADINGFEE");

            builder.Property(p => p.ClientCode).HasColumnType("VARCHAR2(10 CHAR)").HasColumnName("ACLIENTCODE");
            builder.Property(p => p.FeeType).HasColumnType("NUMBER(10,0)").HasColumnName("AFEETYPE");
            builder.Property(p => p.Value).IsRequired().HasColumnName("AVALUE");
            builder.Property(p => p.LastUpdateTime).IsRequired().HasColumnType("TIMESTAMP(7)").HasColumnName("ALASTUPDATETIME"); 
        }
    }
}
