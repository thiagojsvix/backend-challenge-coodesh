using Microsoft.AspNetCore.Mvc;

namespace WebApi.V1.Controllers
{
    [ApiVersionNeutral]
    [Route("api/[controller]")]
    public class StatusCodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStatusCode() => this.Ok();
    }
}
