using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace WebApp2.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class WebApp2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult WebApp2()
        {
            var userName = HttpContext.User.Identity.Name;
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            return Ok($"WebApp2 = UserName: {userName} / UserId: {userIdClaim.Value}");
        }
    }
}