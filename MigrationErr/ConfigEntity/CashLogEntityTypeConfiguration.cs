using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationErr.Models;

namespace MigrationErr.ConfigEntity
{
    public class CashLogEntityTypeConfiguration : IEntityTypeConfiguration<CashLog>
    {
        public void Configure(EntityTypeBuilder<CashLog> builder)
        {
            builder.HasKey(o => new { o.CreateDate, o.TranDate, o.RefId, o.BusinessType, o.ClientCode });
            builder.ToTable("TACC_CASHLOG");

            builder.Property(p => p.UpdateTime).HasColumnName("AUPDATETIME").HasColumnOrder(0);
            builder.Property(p => p.CreateDate).HasColumnName("ACREATEDATE").HasColumnOrder(1);
            builder.Property(p => p.TranDate).HasColumnName("ATRANDATE").HasColumnOrder(2);
            builder.Property(p => p.RefId).HasColumnType("VARCHAR2(50CHAR)").HasColumnName("AREFID").HasColumnOrder(3);
            builder.Property(p => p.SubId).HasColumnType("VARCHAR2(50CHAR)").HasColumnName("ASUBID").HasColumnOrder(4);
            builder.Property(p => p.Status).HasColumnType("NUMBER(2,0)").HasColumnName("ASTATUS").HasColumnOrder(5);
            builder.Property(p => p.UpdateType).HasColumnType("NUMBER(2,0)").HasColumnName("AUPDATETYPE").HasColumnOrder(6);
            builder.Property(p => p.ClientCode).HasColumnType("VARCHAR2(10CHAR)").HasColumnName("ACLIENTCODE").HasColumnOrder(7);
            builder.Property(p => p.StockCode).HasColumnType("VARCHAR2(50CHAR)").HasColumnName("ASTOCKCODE").HasColumnOrder(8);
            builder.Property(p => p.BusinessType).HasColumnName("ABUSINESSTYPE").HasColumnOrder(9);
            builder.Property(p => p.CashAmount).HasColumnName("ACASHAMOUNT").HasColumnOrder(10);
            builder.Property(p => p.Advance).HasColumnName("AADVANCE").HasColumnOrder(11);
            builder.Property(p => p.RemainSecuritiesPower).HasColumnName("AREMAINSECURITIESPOWER").HasColumnOrder(12);
            builder.Property(p => p.Adhoc).HasColumnName("AADHOC").HasColumnOrder(13);
            builder.Property(p => p.MatchedBuy).HasColumnName("AMATCHEDBUY").HasColumnOrder(14);
            builder.Property(p => p.PendingBuy).HasColumnName("APENDINGBUY").HasColumnOrder(15);
            builder.Property(p => p.MatchedBuyFee).HasColumnName("AMATCHEDBUYFEE").HasColumnOrder(16);
            builder.Property(p => p.PendingBuyFee).HasColumnName("APENDINGBUYFEE").HasColumnOrder(17);
            builder.Property(p => p.IntradayDebt).HasColumnName("AINTRADAYDEBT").HasColumnOrder(18);
            builder.Property(p => p.PendingBuyDebt).HasColumnName("APENDINGBUYDEBT").HasColumnOrder(19);
            builder.Property(p => p.InternalTransfer).HasColumnName("AINTERNALTRANSFER").HasColumnOrder(20);
            builder.Property(p => p.ExternalTransfer).HasColumnName("AEXTERNALTRANSFER").HasColumnOrder(21);
            builder.Property(p => p.SMSfee).HasColumnName("ASMSFEE").HasColumnOrder(22);
            builder.Property(p => p.AdvisorSelectFee).HasColumnName("AADVISORSELECTFEE").HasColumnOrder(23);
            builder.Property(p => p.VSDFee).HasColumnName("AVSDFEE").HasColumnOrder(24);
            builder.Property(p => p.RemainDebt).HasColumnName("AREMAINDEBT").HasColumnOrder(25);
            builder.Property(p => p.DebtInterest).HasColumnName("ADEBTINTEREST").HasColumnOrder(26);
            builder.Property(p => p.CreditLine).HasColumnName("ACREDITLINE").HasColumnOrder(27);
            builder.Property(p => p.ReceivableT0).HasColumnName("ARECEIVABLE_T0").HasColumnOrder(28);
            builder.Property(p => p.ReceivableT1).HasColumnName("ARECEIVABLE_T1").HasColumnOrder(29);
            builder.Property(p => p.ReceivableT2).HasColumnName("ARECEIVABLE_T2").HasColumnOrder(30);
            builder.Property(p => p.ReceivableDividend).HasColumnName("ARECEIVABLE_DIVIDEND").HasColumnOrder(31);
            builder.Property(p => p.ReceivableMatureCW).HasColumnName("ARECEIVABLE_MATURECW").HasColumnOrder(32);
            builder.Property(p => p.ReceivableOddlot).HasColumnName("ARECEIVABLE_ODDLOT").HasColumnOrder(33);
            builder.Property(p => p.DVSD).HasColumnName("ADVSD").HasColumnOrder(34);
            builder.Property(p => p.UnpaidVM).HasColumnName("AUNPAIDVM").HasColumnOrder(35);
            builder.Property(p => p.TransferDFPTSToDVSD).HasColumnName("ATRANSFER_DFPTSTODVSD").HasColumnOrder(36);
            builder.Property(p => p.TransferDVSDToDFPTS).HasColumnName("ATRANSFER_DVSDTODFPTS").HasColumnOrder(37);
            builder.Property(p => p.FUTradingTax).HasColumnName("AFUTRADINGTAX").HasColumnOrder(38);
            builder.Property(p => p.FSavingPower).HasColumnName("AFSAVINGPOWER").HasColumnOrder(39);
            builder.Property(p => p.BankGuarantee).HasColumnName("ABANKGUARANTEE").HasColumnOrder(40);
            builder.Property(p => p.FSaving).HasColumnName("AFSAVING").HasColumnOrder(41);
            builder.Property(p => p.BankSaving).HasColumnName("ABANKSAVING").HasColumnOrder(42);
            builder.Property(p => p.Desc).HasColumnType("VARCHAR2(2000CHAR)").HasColumnName("ADESC").HasColumnOrder(43);
            builder.Property(p => p.TopicName).HasColumnType("VARCHAR2(50CHAR)").HasColumnName("ATOPICNAME").HasColumnOrder(44);
            builder.Property(p => p.Partition).HasColumnName("APARTITION").HasColumnOrder(45);
            builder.Property(p => p.Offset).HasColumnName("AOFFSET").HasColumnOrder(46);
            builder.Property(p => p.FGuarantee).HasColumnName("AFGUARANTEE").HasColumnOrder(47);


        }
    }
}
