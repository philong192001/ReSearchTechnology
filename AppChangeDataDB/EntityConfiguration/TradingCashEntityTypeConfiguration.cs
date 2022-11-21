using AppChangeDataDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppChangeDataDB.EntityConfiguration
{
    public class TradingCashEntityTypeConfiguration : IEntityTypeConfiguration<TradingCash>
    {
        public void Configure(EntityTypeBuilder<TradingCash> builder)
        {
            builder.HasKey(o => o.ClientCode);
            builder.Ignore(o => o.RemainingCashAmount);
            builder.Ignore(o => o.PurchasingPowerTotal);
            builder.Ignore(o => o.NetAssetValue);
            builder.Ignore(o => o.ReceivableCashOther);
            builder.Ignore(o => o.ReceivableCashTotal);
            builder.Ignore(o => o.TransferringAmount);

            builder.ToTable("TACC_TRADINGCASH");

            builder.Property(p => p.ClientCode).HasColumnType("VARCHAR2(10 CHAR)").HasColumnName("ACLIENTCODE");
            builder.Property(p => p.CashAmount).HasColumnName("ACASHAMOUNT");
            builder.Property(p => p.Advance).HasColumnName("AADVANCE");
            builder.Property(p => p.RemainSecuritiesPower).HasColumnName("AREMAINSECURITIESPOWER");
            builder.Property(p => p.FSavingPower).HasColumnName("AFSAVINGPOWER");
            builder.Property(p => p.Adhoc).HasColumnName("AADHOC");
            builder.Property(p => p.MatchedBuy).HasColumnName("AMATCHEDBUY");
            builder.Property(p => p.PendingBuy).HasColumnName("APENDINGBUY");
            builder.Property(p => p.IntradayDebt).HasColumnName("AINTRADAYDEBT");
            builder.Property(p => p.PendingBuyDebt).HasColumnName("APENDINGBUYDEBT");
            builder.Property(p => p.MatchedBuyFee).HasColumnName("AMATCHEDBUYFEE");
            builder.Property(p => p.PendingBuyFee).HasColumnName("APENDINGBUYFEE");
            builder.Property(p => p.InternalTransfer).HasColumnName("AINTERNALTRANSFER");
            builder.Property(p => p.ExternalTransfer).HasColumnName("AEXTERNALTRANSFER");
            builder.Property(p => p.FeeSum).HasColumnName("AFEESUM");
            builder.Property(p => p.CreditLine).HasColumnName("ACREDITLINE");
            builder.Property(p => p.RemainDebt).HasColumnName("AREMAINDEBT");
            builder.Property(p => p.DebtInterest).HasColumnName("ADEBTINTEREST");
            builder.Property(p => p.ReceivableT0).HasColumnName("ARECEIVABLE_T0");
            builder.Property(p => p.ReceivableT1).HasColumnName("ARECEIVABLE_T1");
            builder.Property(p => p.ReceivableT2).HasColumnName("ARECEIVABLE_T2");
            builder.Property(p => p.ReceivableDividend).HasColumnName("ARECEIVABLE_DIVIDEND");
            builder.Property(p => p.ReceivableMatureCW).HasColumnName("ARECEIVABLE_MATURECW");
            builder.Property(p => p.ReceivableOddlot).HasColumnName("ARECEIVABLE_ODDLOT");
            builder.Property(p => p.FSaving).HasColumnName("AFSAVING");
            builder.Property(p => p.BankGuarantee).HasColumnName("ABANKGUARANTEE");
            builder.Property(p => p.BankSaving).HasColumnName("ABANKSAVING");
            builder.Property(p => p.FGuarantee).HasColumnName("AFGUARANTEE");
            builder.Property(p => p.LastUpdateTime).IsRequired().HasColumnType("TIMESTAMP(7)").HasColumnName("ALASTUPDATETIME");
            builder.Ignore(p=>p.LastUpdateTime).Property(p => p.LastUpdateTime).HasColumnName("ALASTUPDATETIME");

        }
    }
}
