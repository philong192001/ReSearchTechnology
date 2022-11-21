using System;
using System.Collections.Generic;

namespace Authen.Test.Models
{
    public partial class TauthInternalsessionlog
    {
        public DateTime? Atblid { get; set; }
        public string Aloginname { get; set; }
        public string Aerrcode { get; set; }
        public string Aerrmessage { get; set; }
        public bool? Asource { get; set; }
        public string Aipserver { get; set; }
        public string Aipclient { get; set; }
        public string Areferer { get; set; }
        public string Auseragent { get; set; }
        public string Abrowser { get; set; }
        public DateTime? Alogtime { get; set; }
        public string Aactivity { get; set; }
        public string Abrowsername { get; set; }
        public string Abrowservers { get; set; }
    }
}
