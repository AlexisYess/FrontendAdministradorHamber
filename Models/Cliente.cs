using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Hamber.blazor.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte Status { get; set; }
        public DateTime Fecha { get; set; }
    }
}
