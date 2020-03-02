using Microsoft.AspNetCore.Mvc;

namespace PetProject.Messenger.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok("Hey!");
        }
    }
}