using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExample.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return new RedirectToPageResult("Privacy") ;
        }
    }
}
