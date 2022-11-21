namespace MigrationErr.Models
{
    public class TradingFeeItem
    {
        public string ClientCode { get; init; }
        public FeeType FeeType { get; init; }
        public long Value { get; set; }
    }

    public enum FeeType
    {
        SMSFee = 1,
        VSDFee = 2,
        AdvisorSelectFee = 3
    }

}
