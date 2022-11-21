using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.API.Models
{
    public class CheckLogin 
    {
        [Key]
        public int Id { get; set; }
        public string Time { get; set; }

        public int UserId { get; set; }

    }
}
