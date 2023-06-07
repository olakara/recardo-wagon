using FourThings.Logger;
using Microsoft.AspNetCore.Mvc;

namespace FourThings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        
        // GET
        [HttpGet]
        public IActionResult Get()
        {
            _logger.CustomLog("ValuesController");
            return Ok(new [] {"One","Two"});
        }
    }
}