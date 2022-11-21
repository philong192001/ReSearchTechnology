namespace Locust.LoadTestHttp.Models
{
    public class OrderRequest
    {
        public string? RequestId { get; set; }
        public int? Amount { get; set; }
        public string? ClientCode { get; set; }
        public string? ResponseAddress { get; set; }
        public bool? IsReleaseHold { get; set; }
        public int? ActionType { get; set; }
    }
}
