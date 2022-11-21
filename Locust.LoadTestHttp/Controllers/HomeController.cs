using Locust.LoadTestHttp.KafkaBus;
using Locust.LoadTestHttp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locust.LoadTestHttp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProducerOrder _producer;
        public HomeController(IProducerOrder producer)
        {
            _producer = producer;
        }


        [HttpPost]
        public IActionResult OrderApi(Order order)
        {
            try
            {
                _producer.Producer(order);
                return Ok("OKE");
            }
            catch (Exception e )
            {
                return BadRequest(e.Message);
            }
        }
    }
}
