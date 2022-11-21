namespace MappingDataDB.Models
{
    public class Transaction
    {
        public decimal ATRANID { get; set; }
		public decimal AORDERID { get; set; }
		public string ACLIENTCODE { get; set; }
		public string ASTOCKCODE { get; set; }
		public string AEXCHANGE { get; set; }
		public string ABUYSELL { get; set; }
		public string AORDERTYPE { get; set; }
		public decimal AQUANTITY { get; set; }
		public decimal APRICE { get; set; }
		public string APRICETYPE { get; set; }
		public string ATRADINGACCOUNT { get; set; }
		public string APLACEDBY { get; set; }
		public string APRODUCTTYPE { get; set; }
		public string AMARKETSEGMENT { get; set; }
		public string ACONTRACTNO { get; set; }
		public decimal ACANCELFLAG { get; set; }
		public decimal AMODIFYFLAG { get; set; }
		public DateTime ALASTTRADEDTIME { get; set; }
		public decimal AORIGORDERID { get; set; }
		public string ASOURCE { get; set; }
		public DateTime ADATETIME { get; set; }
		public decimal AIS3RDPARTY { get; set; }
		public decimal ALASTTRANID { get; set; }
		public string APTTYPE { get; set; }
		public decimal ALATESTID { get; set; }
	}
}
