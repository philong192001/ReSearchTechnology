﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.API.Models
{
    public class Login
    {
        public string Time { get; set; }
        public UserTest User { get; set; }
        public Permit Permit { get; set; }

    }
}
