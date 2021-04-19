using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication_TokenBarer.Models;

namespace JWTAuthentication_TokenBarer.Interfaces
{
    public interface IAuthenticateService
    {
        Student Authenticate(String userName, String password);
    }
}
