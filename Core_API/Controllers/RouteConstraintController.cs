using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]/[action]/{id:int}")] // route constraint
    [ApiController]
    public class RouteConstraintController : ControllerBase
    {
        [HttpGet("{id1}")] // Template
        public IActionResult Accept(string id1)
        {
            return Ok(id1);
        }
    }
}
