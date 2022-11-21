namespace MigrationErr.Models
{
    public class SecuritiesLog
    {
        public string? TopicName { get; set; }
        public long? Partition { get; set; }
        public long? Offset { get; set; }
        public DateTime? UpdateTime { get; set; }

        public DateTime CreateDate { get; init; }
        public DateTime? TranDate { get; set; }
        public string RefId { get; init; }
        public string? SubId { get; set; }
        public byte? Status { get; set; }
        public byte? UpdateType { get; set; }

        public string ClientCode { get; init; }

        public string? StockCode { get; set; }

        public int BusinessType { get; init; }

        public long? TradingAvail { get; set; }

        public long? TradingAvail_Mar { get; set; }

        public long? PendingBuy { get; set; }

        public long? PendingSell { get; set; }

        public long? PendingSell_Mar { get; set; }

        public long? MatchedBuyIntraday { get; set; }

        public long? MatchedSellIntraday { get; set; }

        public long? MatchedSellIntraday_Mar { get; set; }

        public long? ReceivableT1 { get; set; }

        public long? ReceivableT2 { get; set; }

        public long? ReceivableRight { get; set; }

        public long? Dividend { get; set; }

        public long? Esop { get; set; }

        public long? Restricted { get; set; }

        public long? MortgageAtBank { get; set; }

        public long? Holding { get; set; }

        public long? TradingWaiting { get; set; }

        public long? EsopWaiting { get; set; }

        public long? RestrictedWaiting { get; set; }

        public long? MortgageBankWaiting { get; set; }

        public long? HoldingWaiting { get; set; }

        public long? WaitingFromCustody { get; set; }

        public long? MarproSuspend { get; set; }

        public long? NetPosition { get; set; }

        public long? OpenPosition { get; set; }

        public long? Price { get; set; }

        public long? VmIntraday { get; set; }

        public string? StockCode2 { get; set; }

        public string? Desc { get; set; }

    }
}
