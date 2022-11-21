namespace MigrationErr.Models
{
    public class CashLog
    {
        public string? TopicName { get; set; }
        public long? Partition { get; set; }
        public long? Offset { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? CreateDate { get; init; }

        public DateTime? TranDate { get; set; }

        public string? RefId { get; init; }

        public string? SubId { get; set; }

        public byte? Status { get; set; }

        public byte? UpdateType { get; set; }

        public string ClientCode { get; init; }
        public string? StockCode { get; set; }

        public int BusinessType { get; init; }

        public long? CashAmount { get; set; }

        public long? Advance { get; set; }

        public long? RemainSecuritiesPower { get; set; }

        public long? Adhoc { get; set; }

        public long? MatchedBuy { get; set; }

        public long? PendingBuy { get; set; }

        public long? MatchedBuyFee { get; set; }

        public long? PendingBuyFee { get; set; }

        public long? IntradayDebt { get; set; }

        public long? PendingBuyDebt { get; set; }

        public long? InternalTransfer { get; set; }

        public long? ExternalTransfer { get; set; }

        public long? SMSfee { get; set; }

        public long? AdvisorSelectFee { get; set; }

        public long? VSDFee { get; set; }

        public long? RemainDebt { get; set; }

        public long? DebtInterest { get; set; }

        public long? CreditLine { get; set; }

        public long? ReceivableT0 { get; set; }

        public long? ReceivableT1 { get; set; }

        public long? ReceivableT2 { get; set; }

        public long? ReceivableDividend { get; set; }

        public long? ReceivableMatureCW { get; set; }

        public long? ReceivableOddlot { get; set; }

        public long? DVSD { get; set; }

        public long? UnpaidVM { get; set; }

        public long? TransferDFPTSToDVSD { get; set; }

        public long? TransferDVSDToDFPTS { get; set; }

        public long? FUTradingTax { get; set; }

        public long? FSavingPower { get; set; }

        public long? BankGuarantee { get; set; }

        public long? FSaving { get; set; }

        public long? BankSaving { get; set; }
        public long? FGuarantee { get; set; }

        public string? Desc { get; set; }
    }
}
