using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace WebApp1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApp1Controller : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "admin", Policy = "İstanbulPolicy")]
        [Authorize(Policy = "AgePolicy")]
        public IActionResult WebApp1()
        {
            var userName = HttpContext.User.Identity.Name;
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            return Ok($"WebApp1 = UserName: {userName} / UserId: {userIdClaim.Value}");
        }
    }
}