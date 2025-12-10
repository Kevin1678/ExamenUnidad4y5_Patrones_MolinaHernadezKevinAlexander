using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.Decorator
{
    public class RolInvitado : DecoradorRol
    {
        public RolInvitado(IUsuarioAcceso usuario) : base(usuario) { }

        public override void Acceder()
        {
            base.Acceder();
            Console.WriteLine("→ Permiso: acceso de invitado.");
        }
    }
}
