namespace MigrationErr.Models
{
    public class FuturesSecuritiesItem
    {
        public string StockCode { get; init; }
        public string ClientCode { get; init; }
        public long PendingBuy { get; set; }
        public long PendingSell { get; set; }
        public long MatchedBuyIntraday { get; set; }
        public long MatchedSellIntraday { get; set; }
        public long NetPosition { get; set; }
        public long OpenPosition { get; set; }
        public long VMIntraday { get; set; }
    }
}
