using Examen_Unidad4y5.Fachada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.State
{
    public class EstadoNoAutenticado : IEstadoSesion
    {
        public void Manejar(SistemaAccesoFacade sistema)
        {
            Console.WriteLine("No has iniciado sesión.");
        }
    }
}
