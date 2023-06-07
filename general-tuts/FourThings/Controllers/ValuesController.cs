using Microsoft.AspNetCore.Mvc;

namespace FourThings.Controllers
{
    public class ValuesController : ControllerBase
    {
        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new [] {"One","Two"});
        }
    }
}