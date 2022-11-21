namespace AutoPubMsg.Models
{
    public class BaseAccountCommand
    {
        public DateTime CreateDate { get; set; }
        public string RefId { get; set; }
        public string ClientCode { get; set; }
        public int BusinessType { get; set; }
        public DateTime UpdateTime { get; set; }

        public string Desc { get; set; }

        public string TopicName { get; set; }
        public long Partition { get; set; }
        public long Offset { get; set; }
    }
}
