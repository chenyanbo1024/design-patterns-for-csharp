using Core.Proxy;
using Microsoft.AspNetCore.Mvc;

namespace Core.Start.Controllers
{
    /// <summary>
    /// 代理模式
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices]IUserService userService)
        {
            UserServiceProxy userServiceProxy = new(userService);

            var login1 = userServiceProxy.Login(username: "bobo", password: "bobo1024");
            var login2 = userServiceProxy.Login(username: "error", password: "error445121");

            var register1 = userServiceProxy.Register(username: "bobo", password: "bobo1024");
            var register2 = userServiceProxy.Register(username: "b", password: "bobo1024");

            return Ok($"login1:{login1}, login2:{login2}, register1:{register1}, register2:{register2}");
        }
    }
}
