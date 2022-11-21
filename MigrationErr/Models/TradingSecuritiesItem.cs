namespace MigrationErr.Models
{
    public class TradingSecuritiesItem
    {
        public string StockCode { get; init; }
        public string ClientCode { get; init; }
        public long TradingAvail { get; set; }
        public long TradingAvail_Mar { get; set; }
        public long PendingSell { get; set; }
        public long PendingSell_Mar { get; set; }
        public long MatchedSellIntraday { get; set; }
        public long MatchedSellIntraday_Mar { get; set; }
        public long Dividend { get; set; }
        public long Restricted { get; set; }
        public long MortgageAtBank { get; set; }
        public long Holding { get; set; }
        public long ESOP { get; set; }
        public long MarproSuspend { get; set; }
        public long MatchedBuyIntraday { get; set; }
        public long ReceivableT1 { get; set; }
        public long ReceivableT2 { get; set; }
        public long ReceivableRight { get; set; }
        public long RestrictedWaiting { get; set; }
        public long MortgageAtBankWaiting { get; set; }
        public long HoldingWaiting { get; set; }
        public long TradingWaiting { get; set; }
        public long WaitingFromCustody { get; set; }
        public long ESOPWaiting { get; set; }
        public long OddlotSellIntraday { get; set; }
    }
}
