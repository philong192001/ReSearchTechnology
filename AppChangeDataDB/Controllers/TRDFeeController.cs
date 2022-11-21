using AppChangeDataDB.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AppChangeDataDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TRDFeeController : ControllerBase
    {
        private readonly AccountDbContext _context;
        private readonly AccountDbContextClone _contextClone;
        public TRDFeeController(AccountDbContext context, AccountDbContextClone contextClone)
        {
            _context = context;
            _contextClone = contextClone;
        }


        [HttpGet]
        public IActionResult ChangeFee()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            var dbOld = _context.TradingFeeItems.ToList();

            foreach (var item in dbOld)
            {
                data.Add(Guid.NewGuid().ToString(), JsonSerializer.Serialize(item));
                _contextClone.Add(item);

            }
            
            _contextClone.SaveChanges();
            var dbNew = _contextClone.TradingFeeItems.ToList();
            
            
            return Ok(dbOld.Count() + "--------" + dbNew.Count());
        }
    }
}
