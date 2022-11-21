using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationErr.Models;

namespace MigrationErr.ConfigEntity
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
        }
    }
}
