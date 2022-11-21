using Authen.API.Data;
using Authen.API.Helper;
using Authen.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Authen.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly OracleContext _context;
        public LoginController(OracleContext context)
        {
            _context = context;
        }

        [HttpPost("/Register")]
        public IActionResult Register(Login loginCache)
        {
            CheckLogin login = new CheckLogin();
            Permit permit = new Permit();
            UserTest user = new UserTest();

            user.ALOGINNAME = loginCache.User.ALOGINNAME;
            user.ATOKEN = loginCache.User.ATOKEN;
            user.AIPSERVER = loginCache.User.AIPSERVER;
            user.AIPCLIENT = loginCache.User.AIPCLIENT;
            user.AUSERAGENT = loginCache.User.AUSERAGENT;
            user.ABROWSER = loginCache.User.ABROWSER;
            user.ALOGINTIME = loginCache.User.ALOGINTIME;
            user.ALOGOUTTIME = loginCache.User.ALOGOUTTIME;
            user.ASESSIONNO = loginCache.User.ASESSIONNO;
            user.ASESSIONFIRSTLOGIN = loginCache.User.ASESSIONFIRSTLOGIN;
            user.AISMOBILE = loginCache.User.AISMOBILE;
            user.ABROWSERNAME = loginCache.User.ABROWSERNAME;
            user.ABROWSERVERS = loginCache.User.ABROWSERVERS;
            user.ACHKPASS2 = loginCache.User.ACHKPASS2;
            _context.Add(user);
            _context.SaveChanges();

            permit.EzTradeChargeRate = loginCache.Permit.EzTradeChargeRate;
            permit.EzTrade = loginCache.Permit.EzTrade;
            permit.EzTransfer = loginCache.Permit.EzTransfer;
            permit.EzAdvance = loginCache.Permit.EzAdvance;
            permit.EzMargin = loginCache.Permit.EzMargin;
            permit.EzMortgage = loginCache.Permit.EzMortgage;
            permit.EzOddlot = loginCache.Permit.EzOddlot;
            permit.EzMarginPro = loginCache.Permit.EzMarginPro;
            permit.EzFuture = loginCache.Permit.EzFuture;
            permit.EzTvdt = loginCache.Permit.EzTvdt;
            permit.vTblid = loginCache.Permit.vTblid;
            permit.vFeeUP = loginCache.Permit.vFeeUP;
            permit.vFeeUP_CCQ = loginCache.Permit.vFeeUP_CCQ;
            permit.vFeeLISTED_CP = loginCache.Permit.vFeeLISTED_CP;
            permit.vFeeHSX_CP = loginCache.Permit.vFeeHSX_CP;
            permit.vFeeRate_TP = loginCache.Permit.vFeeRate_TP;
            permit.vFeeLISTED_ETF = loginCache.Permit.vFeeLISTED_ETF;
            permit.vFeeLISTED_CCQ = loginCache.Permit.vFeeLISTED_CCQ;
            permit.vFeeHSX_CCQ = loginCache.Permit.vFeeHSX_CCQ;
            permit.vFeeHSX_CQ = loginCache.Permit.vFeeHSX_CQ;
            permit.vFeeHSX_ETF = loginCache.Permit.vFeeHSX_ETF;
            permit.vFeeLISTED_CQ = loginCache.Permit.vFeeLISTED_CQ;
            permit.UserId = user.ID;

            login.Time = DateTime.Now.ToString();
            login.UserId = user.ID;
            _context.Add(login);
            _context.Add(permit);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("/Login")]
        public IActionResult Login(FormLogin login)
        {

            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(login.UserName))
                {
                    return BadRequest("fail");
                }
                var user = _context.UserLogin.Where(s => s.ALOGINNAME.Equals(login.UserName) && s.ACHKPASS2.Equals(login.Password)).FirstOrDefault();
                // ).FirstOrDefault(

                if (user != null)
                {
                    var result = from u in _context.UserLogin
                                 join p in _context.Permits on u.ID equals p.UserId
                                 join r in _context.ResponseLogin on u.ID equals r.UserId
                                 where u.ALOGINNAME == login.UserName && u.ACHKPASS2 == login.Password
                                 select new Login
                                 {
                                     Time = r.Time,
                                     User = u,
                                     Permit = p,

                                 };


                    
                    return Ok(result);
                }
                else
                {
                    return BadRequest("fail");
                }
            }
            return BadRequest("fail");
        }

        [HttpGet("/SetToken")]
        public IActionResult SetToken()
        {
            var user = new SessionTest() { Id = 1, Name = " LONG ", Age = 15 };
            HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
            //SessionHelper.SetObjectAsJson(_httpContext.Session, "product","123");
            //_httpContext.Session.SetString("acc", "longpv");
            //_httpContext.HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
            return Ok();
        }
        [HttpGet("/GetToken")]
        public IActionResult GetToken()
        {
            //_httpContext.Session.GetString("acc");
            return Ok();
        }

    }
}
