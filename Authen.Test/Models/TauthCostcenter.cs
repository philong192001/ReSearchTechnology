using System;
using System.Collections.Generic;

namespace Authen.Test.Models
{
    public partial class TauthCostcenter
    {
        public decimal? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte? Type { get; set; }
        public string Description { get; set; }
        public bool? Aactive { get; set; }
    }
}
