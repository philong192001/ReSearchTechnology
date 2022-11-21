using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationErr.Models;

namespace MigrationErr.ConfigEntity
{
    public class FuturesCashEntityTypeConfiguration : IEntityTypeConfiguration<FuturesCash>
    {
        public void Configure(EntityTypeBuilder<FuturesCash> builder)
        {
            builder.HasKey(o => o.ClientCode);
            builder.ToTable("TACC_FUTURESCASH");

            builder.Property(p => p.ClientCode).HasColumnType("VARCHAR2(10 CHAR)").HasColumnName("ACLIENTCODE");
            builder.Property(p => p.DFPTS).HasColumnName("ADFPTS");
            builder.Property(p => p.MatchedFee).HasColumnName("AMATCHEDFEE");
            builder.Property(p => p.InternalTransfer).HasColumnName("AINTERNALTRANSFER");
            builder.Property(p => p.VSDFee).HasColumnName("AVSDFEE");
            builder.Property(p => p.RemainDebt).HasColumnName("AREMAINDEBT");
            builder.Property(p => p.DebtInterest).HasColumnName("ADEBTINTEREST");
            builder.Property(p => p.DVSD).HasColumnName("ADVSD");
            builder.Property(p => p.TransferDVSDtoDFPTS).HasColumnName("ATRANSFER_DVSDTODFPTS");
            builder.Property(p => p.TransferDFPTStoDVSD).HasColumnName("ATRANSFER_DFPTSTODVSD");
            builder.Property(p => p.UnpaidVM).HasColumnName("AUNPAIDVM");
            builder.Property(p => p.FUTradingTax).HasColumnName("AFUTRADINGTAX");

        }
    }
}
