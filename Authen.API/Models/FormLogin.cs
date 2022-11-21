using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.API.Models
{
    public class FormLogin
    {
        public string UserName { get; set; }
        public int Password { get; set; }
    }
}
