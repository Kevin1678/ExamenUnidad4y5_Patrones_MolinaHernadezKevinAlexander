using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Modelos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public ConsoleColor ColorTexto { get; set; }
        public List<TipoRol> Roles { get; set; } = new List<TipoRol>();
    }
}
