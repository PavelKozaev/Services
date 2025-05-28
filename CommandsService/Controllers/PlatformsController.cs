using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{    
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
                        
        }

        [HttpPost]
        public ActionResult TestInBoundConnection()
        {
            Console.WriteLine("--> InBound POST Command Service");

            return Ok("InBound test of from Platforms Controller");
        }
    }
}
