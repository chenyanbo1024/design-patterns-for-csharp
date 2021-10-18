using Microsoft.AspNetCore.Mvc;

namespace Core.Start.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuilderController : ControllerBase
    {
        [HttpGet("builder")]
        public IActionResult Builder()
        {
            var url = new Builder.UrlBuilder()
                .SetSSL(true)
                .SetDomain("docs.microsoft.com")
                .SetPath("/en-us/aspnet/core/release-notes/aspnetcore-5.0")
                .SetQuery("view=aspnetcore-5.0")
                .Build();

            return Ok($"URL: {url}");
        }
    }
}