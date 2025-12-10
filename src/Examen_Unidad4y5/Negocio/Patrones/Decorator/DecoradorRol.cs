using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.Decorator
{
    public abstract class DecoradorRol : IUsuarioAcceso
    {
        protected IUsuarioAcceso _usuario;

        protected DecoradorRol(IUsuarioAcceso usuario)
        {
            _usuario = usuario;
        }

        public virtual void Acceder()
        {
            _usuario.Acceder();
        }
    }
}
