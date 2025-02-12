using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProject.Domain.Entities;

namespace YourProject.Domain.Services
{
    public interface IAuthenticator
    {
        bool Authenticate(User user);
    }
}
