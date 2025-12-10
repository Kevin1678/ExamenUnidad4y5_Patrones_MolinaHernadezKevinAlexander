using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.Decorator
{
    public class UsuarioBase : IUsuarioAcceso
    {
        public void Acceder()
        {
            Console.WriteLine("Acceso básico al sistema.");
        }
    }
}
