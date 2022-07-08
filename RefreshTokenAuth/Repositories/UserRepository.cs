using RefreshTokenAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefreshTokenAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User {Id = 1, Username = "batman", Password = "batman", Role = "manager"},
                new User { Id = 1, Username = "batman", Password = "batman", Role = "employer" }
            };

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
