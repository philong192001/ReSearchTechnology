namespace MigrationErr.Models
{
    public class FuturesCash
    {
        public string ClientCode { get; init; }
        public long DFPTS { get; set; }
        public long MatchedFee { get; set; }
        public long InternalTransfer { get; set; }
        public long VSDFee { get; set; }
        public long RemainDebt { get; set; }
        public long DebtInterest { get; set; }
        public long DVSD { get; set; }
        public long TransferDVSDtoDFPTS { get; set; }
        public long TransferDFPTStoDVSD { get; set; }
        public long UnpaidVM { get; set; }
        public long FUTradingTax { get; set; }
    }
}
