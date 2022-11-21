using System;
using System.Collections.Generic;

namespace Authen.Test.Models
{
    public partial class TauthSysuser
    {
        public long? Auserid { get; set; }
        public string Ausername { get; set; }
        public string Afullname { get; set; }
        public string Adescription { get; set; }
        public string Alocal { get; set; }
        public string Adept { get; set; }
        public string Asubcstcencde { get; set; }
        public byte? Ausertypereport { get; set; }
        public byte? Ausertypemargin { get; set; }
        public byte? Auserlockstt { get; set; }
        public bool? Astatusotp { get; set; }
    }
}
