using System;

namespace webapi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
    }
}
