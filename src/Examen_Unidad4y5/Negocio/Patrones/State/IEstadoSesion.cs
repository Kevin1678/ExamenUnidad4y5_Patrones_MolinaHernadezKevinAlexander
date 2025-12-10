using Examen_Unidad4y5.Fachada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.State
{
    public interface IEstadoSesion
    {
        void Manejar(SistemaAccesoFacade sistema);
    }
}
