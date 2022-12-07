using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Hamber.blazor.Models
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
