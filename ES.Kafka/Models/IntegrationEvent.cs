using MessagePack;
using System;

namespace TestConvertJson.Models
{

    public record IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreationDate = createDate;
        }

        public Guid Id { get; init; }

        public DateTime CreationDate { get; init; }

        public int Partition { get; set; }

        public Guid CorrelationId { get; set; }
    }
    //set true cho MessagePackObject thi khong can danh so key vao Property nua
    [Serializable]
    public record OrderPlacedIntegrationEvent : IntegrationEvent
    {

        public OrderPlacedIntegrationEvent() { }
        public OrderPlacedIntegrationEvent(string clientCode, string stockCode, string exchange,
        string buyOrSell, int quantity, double price, string priceType, string tradingAccount,
        string placeBy, string productType, string marketSegment, string source, Guid correlationId)
        {
            ClientCode = clientCode;
            StockCode = stockCode;
            Exchange = exchange;
            BuyOrSell = buyOrSell;
            Quantity = quantity;
            Price = price;
            PriceType = priceType;
            TradingAccount = tradingAccount;
            PlaceBy = placeBy;
            ProductType = productType;
            MarketSegment = marketSegment;
            Source = source;
            CorrelationId = correlationId;
        }
        public string ClientCode { get; set; }
        public string StockCode { get; set; }
        public string Exchange { get; set; }
        public string BuyOrSell { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string PriceType { get; set; }
        public string TradingAccount { get; set; }
        public string PlaceBy { get; set; }
        public string ProductType { get; set; }
        public string MarketSegment { get; set; }
        public string Source { get; set; }
        public string ErrorCode { get; set; }
    }
}
