using Core.Prototype;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Start.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrototypeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            User user = new User()
                .SetId(1)
                .SetName("Bobo")
                .SetGender("男");

            User user1 = user.Copy();
            bool isEquals = Equals(user, user1);
            return Ok($"两个对象是否相等：{isEquals}");
        }
    }
}
