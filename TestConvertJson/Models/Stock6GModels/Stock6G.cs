using MessagePack;
using System;
using TestConvertJson.Models.Stock6GModels;

namespace TestConvertJson.Models
{
    [MessagePackObject(true)]
    [Serializable]
    public class Stock6G
    {
        public string Time { get; set; }
        public Data Data { get; set; }
    }
    [MessagePackObject(true)]
    public class Data
    {
        public STX STX { get; set; }
        public UPX UPX { get; set; }
        public HCX HCX { get; set; }
        public DVX DVX { get; set; }
    }

}
