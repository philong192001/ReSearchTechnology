using System;
using System.Collections.Generic;

namespace Authen.Test.Models
{
    public partial class TauthWebnav
    {
        public long? Amenuid { get; set; }
        public string Amname { get; set; }
        public string Amnameen { get; set; }
        public string AmlanguageId { get; set; }
        public string Amlink { get; set; }
        public long? Amparent { get; set; }
        public long? Amorder { get; set; }
        public bool? Aloginstate { get; set; }
        public bool? Aactive { get; set; }
        public bool? Ahaslink { get; set; }
        public bool? Aisblank { get; set; }
        public bool? Aisadmin { get; set; }
        public bool? Aisinternal { get; set; }
        public bool? Avlevel { get; set; }
        public bool? Avhaschild { get; set; }
        public bool? Avrootgroup { get; set; }
        public string Asysmodule { get; set; }
        public bool? Atype { get; set; }
        public string Adbname { get; set; }
    }
}
