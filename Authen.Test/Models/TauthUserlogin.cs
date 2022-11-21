﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Authen.Test.Models
{
    public partial class TauthUserlogin
    {
        public string ACLIENTCODE { get; set; }
        public string ACLIENTNAME { get; set; }
        public string APASSWORD { get; set; }
        public string APASSWORDII { get; set; }
        public DateTime? ALASTPASSWORDCHANGEDDATE { get; set; }
        public bool? ARSATOKEN { get; set; }
        public bool? ACLIENTLOCKSTATUS { get; set; }
        public DateTime? ACLIENTLOCKTIME { get; set; }
        public string ADESCRIPTION { get; set; }
        public bool? AFIRSTLOGIN { get; set; }
        public byte? ARETRYCOUNT { get; set; }
        public bool? AUSINGPWD1BY1 { get; set; }
        public string AMOBILEDEVICEID { get; set; }
        public bool? AREASON { get; set; }
    }
}
