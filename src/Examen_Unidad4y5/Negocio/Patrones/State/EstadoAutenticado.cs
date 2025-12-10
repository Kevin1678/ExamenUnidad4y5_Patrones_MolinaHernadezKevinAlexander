using Examen_Unidad4y5.Fachada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Patrones.State
{
    public class EstadoAutenticado : IEstadoSesion
    {
        public void Manejar(SistemaAccesoFacade sistema)
        {
            Console.WriteLine("Usuario autenticado. Puedes acceder al sistema.");
        }
    }
}
