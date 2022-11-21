using System;
using System.Collections.Generic;

namespace Authen.Test.Models
{
    public partial class TauthInternalsession
    {
        public string Aloginname { get; set; }
        public string Atoken { get; set; }
        public string Aipserver { get; set; }
        public string Aipclient { get; set; }
        public string Auseragent { get; set; }
        public string Abrowser { get; set; }
        public DateTime? Alogintime { get; set; }
        public DateTime? Alogouttime { get; set; }
        public string Abrowsername { get; set; }
        public string Abrowservers { get; set; }
    }
}
