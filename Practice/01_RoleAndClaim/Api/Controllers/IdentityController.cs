using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Controllers
{
    [Route("[controller]")]
    //[Authorize]
    public class IdentityController : ControllerBase
    {
        [Authorize(Roles = "superadmin")]
        [HttpGet]
        public IActionResult Get() => new JsonResult(from c in User.Claims select new { c.Type, c.Value });

        [Authorize(Roles = "admin")]
        [Route("{id}")]
        [HttpGet]
        public string Get(int id) => id.ToString();
    }
}
