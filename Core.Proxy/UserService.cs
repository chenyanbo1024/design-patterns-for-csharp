using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Proxy
{
    public class UserService : IUserService
    {
        public string Login(string username, string password)
        {
            // 只进行简单的登录判断，能说明问题就好
            if (username.Equals("bobo") && password.Equals("bobo1024"))
            {
                return "login success";
            }
            return "login fail";
        }

        public bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
