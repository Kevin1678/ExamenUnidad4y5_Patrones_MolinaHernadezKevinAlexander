using Examen_Unidad4y5.Modelos;
using Examen_Unidad4y5.Patrones.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.Factory
{
    public static class RolFactory
    {
        public static IUsuarioAcceso CrearDecorador(TipoRol rol, IUsuarioAcceso actual)
        {
            switch (rol)
            {
                case TipoRol.Administrador:
                    return new RolAdministrador(actual);

                case TipoRol.Editor:
                    return new RolEditor(actual);

                case TipoRol.Invitado:
                    return new RolInvitado(actual);

                default:
                    return actual;
            }
        }
    }
}
