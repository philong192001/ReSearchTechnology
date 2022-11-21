using AppChangeDataDB.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AppChangeDataDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TRDCashController : ControllerBase
    {
        private readonly AccountDbContext _context;
        private readonly AccountDbContextClone _contextClone;
        public TRDCashController(AccountDbContext context, AccountDbContextClone contextClone)
        {
            _context = context;
            _contextClone = contextClone;
        }

        [HttpGet]
        public IActionResult ChangeData()
        {
            var dbOld = _context.TradingCashes.ToList();
            foreach (var item in dbOld)
            {
                var exist = _contextClone.TradingCashes.Find(item.ClientCode);
                if (exist == null)
                {
                    _contextClone.TradingCashes.Add(item);
                }
                else
                {
                    _contextClone.TradingCashes.Update(item);
                }
            }
            _contextClone.SaveChanges();


            return Ok(dbOld.Count()) ;
        }
    }
}
