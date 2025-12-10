using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.Decorator
{
    public class RolAdministrador : DecoradorRol
    {
        public RolAdministrador(IUsuarioAcceso usuario) : base(usuario) { }

        public override void Acceder()
        {
            base.Acceder();
            Console.WriteLine("→ Permiso: gestionar usuarios y roles.");
        }
    }
}
