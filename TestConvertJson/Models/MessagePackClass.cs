using MessagePack;

namespace TestConvertJson.Models
{
    [MessagePackObject]
    //xac dinh class duoc su dung MessagePack
    public class MessagePackClass
    {
        [Key(0)]
        //set key de xac dinh cac propertype duoc Serialize
        public int Age { get; set; }

        [Key(1)]
        public string FirstName { get; set; }

        [Key(2)]
        public string LastName { get; set; }
        
        //Bo qua dem so key -> khong run cung khi using class bang messagepack
        [IgnoreMember]
        public string FullName { get { return FirstName + LastName; } }
    }
}
