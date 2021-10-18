using System;

namespace Core.Proxy
{

    public class UserServiceProxy : IUserService
    {
        private IUserService _userService;
        public UserServiceProxy(IUserService userService)
        {
            _userService = userService;
        }

        public string Login(string username, string password)
        {
            var startTimeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var result = _userService.Login(username, password);
            var endTimeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

            // 也可写入日志等逻辑
            Console.WriteLine($"接口总耗时：{endTimeStamp - startTimeStamp}");

            return result;
        }

        public bool Register(string username, string password)
        {
            var startTimeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var result = _userService.Register(username, password);
            var endTimeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

            // 也可写入日志等逻辑
            Console.WriteLine($"接口总耗时：{endTimeStamp - startTimeStamp}");

            return result;
        }
    }
}
