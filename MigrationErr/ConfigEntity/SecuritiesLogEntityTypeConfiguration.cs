using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationErr.Models;

namespace MigrationErr.ConfigEntity
{
    public class SecuritiesLogEntityTypeConfiguration : IEntityTypeConfiguration<SecuritiesLog>
    {
        public void Configure(EntityTypeBuilder<SecuritiesLog> builder)
        {
            builder.HasKey(o => new { o.CreateDate, o.TranDate, o.RefId, o.BusinessType, o.ClientCode, o.StockCode });
            builder.ToTable("TACC_SECURITIESLOG");

            builder.Property(p => p.UpdateTime).HasColumnName("AUPDATETIME").HasColumnOrder(0);
            builder.Property(p => p.CreateDate).HasColumnName("ACREATEDATE").HasColumnOrder(1);
            builder.Property(p => p.TranDate).HasColumnName("ATRANDATE").HasColumnOrder(2);
            builder.Property(p => p.RefId).HasColumnType("varchar2(50char)").HasColumnName("AREFID").HasColumnOrder(3);
            builder.Property(p => p.SubId).HasColumnType("varchar2(50char)").HasColumnName("ASUBID").HasColumnOrder(4);
            builder.Property(p => p.Status).HasColumnType("NUMBER(2,0)").HasColumnName("ASTATUS").HasColumnOrder(5);
            builder.Property(p => p.UpdateType).HasColumnType("NUMBER(2,0)").HasColumnName("AUPDATETYPE").HasColumnOrder(6);
            builder.Property(p => p.ClientCode).HasColumnType("varchar2(10char)").HasColumnName("ACLIENTCODE").HasColumnOrder(7);
            builder.Property(p => p.StockCode).HasColumnType("varchar2(20char)").HasColumnName("ASTOCKCODE").HasColumnOrder(8);
            builder.Property(p => p.BusinessType).HasColumnName("ABUSINESSTYPE").HasColumnOrder(9);
            builder.Property(p => p.TradingAvail).HasColumnName("ATRADINGAVAIL").HasColumnOrder(10);
            builder.Property(p => p.TradingAvail_Mar).HasColumnName("ATRADINGAVAIL_MAR").HasColumnOrder(11);
            builder.Property(p => p.PendingBuy).HasColumnName("APENDINGBUY").HasColumnOrder(12);
            builder.Property(p => p.PendingSell).HasColumnName("APENDINGSELL").HasColumnOrder(13);
            builder.Property(p => p.PendingSell_Mar).HasColumnName("APENDINGSELL_MAR").HasColumnOrder(14);
            builder.Property(p => p.MatchedBuyIntraday).HasColumnName("AMATCHEDBUYINTRADAY").HasColumnOrder(15);
            builder.Property(p => p.MatchedSellIntraday).HasColumnName("AMATCHEDSELLINTRADAY").HasColumnOrder(16);
            builder.Property(p => p.MatchedSellIntraday_Mar).HasColumnName("AMATCHEDSELLINTRADAY_MAR").HasColumnOrder(17);
            builder.Property(p => p.ReceivableT1).HasColumnName("ARECEIVABLE_T1").HasColumnOrder(18);
            builder.Property(p => p.ReceivableT2).HasColumnName("ARECEIVABLE_T2").HasColumnOrder(19);
            builder.Property(p => p.ReceivableRight).HasColumnName("ARECEIVABLE_RIGHT").HasColumnOrder(20);
            builder.Property(p => p.Dividend).HasColumnName("ADIVIDEND").HasColumnOrder(21);
            builder.Property(p => p.Esop).HasColumnName("AESOP").HasColumnOrder(22);
            builder.Property(p => p.Restricted).HasColumnName("ARESTRICTED").HasColumnOrder(23);
            builder.Property(p => p.MortgageAtBank).HasColumnName("AMORTGAGEATBANK").HasColumnOrder(24);
            builder.Property(p => p.Holding).HasColumnName("AHOLDING").HasColumnOrder(25);
            builder.Property(p => p.TradingWaiting).HasColumnName("ATRADINGWAITING").HasColumnOrder(26);
            builder.Property(p => p.EsopWaiting).HasColumnName("AESOPWAITING").HasColumnOrder(27);
            builder.Property(p => p.RestrictedWaiting).HasColumnName("ARESTRICTEDWAITING").HasColumnOrder(28);
            builder.Property(p => p.MortgageBankWaiting).HasColumnName("AMORTGAGEBANKWAITING").HasColumnOrder(29);
            builder.Property(p => p.HoldingWaiting).HasColumnName("AHOLDINGWAITING").HasColumnOrder(30);
            builder.Property(p => p.WaitingFromCustody).HasColumnName("AWAITINGFROMCUSTODY").HasColumnOrder(31);
            builder.Property(p => p.MarproSuspend).HasColumnName("AMARPROSUSPEND").HasColumnOrder(32);
            builder.Property(p => p.NetPosition).HasColumnName("ANETPOSITION").HasColumnOrder(33);
            builder.Property(p => p.OpenPosition).HasColumnName("AOPENPOSITION").HasColumnOrder(34);
            builder.Property(p => p.Price).HasColumnName("APRICE").HasColumnOrder(35);
            builder.Property(p => p.VmIntraday).HasColumnName("AVMINTRADAY").HasColumnOrder(36);
            builder.Property(p => p.StockCode2).HasColumnType("varchar2(20char)").HasColumnName("ASTOCKCODE2").HasColumnOrder(37);
            builder.Property(p => p.Desc).HasColumnType("varchar2(2000char)").HasColumnName("ADESC").HasColumnOrder(38);
            builder.Property(p => p.TopicName).HasColumnType("VARCHAR2(50CHAR)").HasColumnName("ATOPICNAME").HasColumnOrder(39);
            builder.Property(p => p.Partition).HasColumnName("APARTITION").HasColumnOrder(40);
            builder.Property(p => p.Offset).HasColumnName("AOFFSET").HasColumnOrder(41);

        }
    }
}
