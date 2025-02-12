using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProject.Domain.Entities;

namespace YourProject.Domain.Services
{
    public class Authenticator : IAuthenticator
    {
        public bool Authenticate(User user)
        {
            return user.Username == "admin" && user.Password == "admin";
        }
    }
}
