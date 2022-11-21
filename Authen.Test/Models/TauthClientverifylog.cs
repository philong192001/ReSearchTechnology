using System;
using System.Collections.Generic;

namespace Authen.Test.Models
{
    public partial class TauthClientverifylog
    {
        public long? Atblid { get; set; }
        public string Aloginname { get; set; }
        public string Aerrcode { get; set; }
        public string Aerrmessage { get; set; }
        public bool? Asource { get; set; }
        public string Auseragent { get; set; }
        public DateTime? Alogtime { get; set; }
        public string Aactivity { get; set; }
        public string Averifycode { get; set; }
    }
}
