using Microsoft.AspNetCore.Mvc;

namespace Core.Start.Controllers
{
    /// <summary>
    /// 单例模式
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var instance = Singleton.Singleton.Instance;
            return Ok();
        }
    }
}