using Authen.Test.Context;
using Authen.Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authen.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ModelContext _contextNong;
        public TestController(ModelContext contextNong)
        {
            _contextNong = contextNong;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var a = from u in _contextNong.TauthUserlogin
                    join p in _contextNong.TauthClientsession on u.ACLIENTCODE equals p.ALOGINNAME
                    join r in _contextNong.TauthClientsessionlog on u.ACLIENTCODE equals r.ALOGINNAME
                    where u.ACLIENTCODE == "058C111111" && u.APASSWORD == "36ed58c5c14dc2f58eef099585d2a939"
                    select new 
                    {
                        Time = DateTime.Now,
                        User = u,
                        CLS = p,
                        CLSL = r
                    };
            if (a == null)
            {
                return Ok("NULL roif hahahah");
            }
            else
            {
                return Ok(a.ToList());

            }
        }
    }
}
