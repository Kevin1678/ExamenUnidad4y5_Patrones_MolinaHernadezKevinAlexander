using Examen_Unidad4y5.Fachada;
using Examen_Unidad4y5.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5
{
    internal class Program
    {
        static SistemaAccesoFacade sistema = new SistemaAccesoFacade();
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n--- CONTROL DE ACCESO ---");
                Console.WriteLine("1. Registrar usuario");
                Console.WriteLine("2. Asignar rol");
                Console.WriteLine("3. Iniciar sesión");
                Console.WriteLine("4. Mostrar permisos");
                Console.WriteLine("5. Cerrar sesión");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: RegistrarUsuario(); break;
                    case 2: AsignarRol(); break;
                    case 3: IniciarSesion(); break;
                    case 4: sistema.MostrarAcceso(); break;
                    case 5: sistema.CerrarSesion(); break;
                }

            } while (opcion != 0);
        }

        static void RegistrarUsuario()
        {
            Console.Write("Nombre: ");
            string n = Console.ReadLine();

            Console.Write("Password: ");
            string p = Console.ReadLine();

            Console.WriteLine("Elige color (1=Rojo, 2=Verde, 3=Azul): ");
            var color = int.Parse(Console.ReadLine());

            sistema.RegistrarUsuario(n, p,
                color == 1 ? ConsoleColor.Red :
                color == 2 ? ConsoleColor.Green :
                             ConsoleColor.Blue);
        }

        static void AsignarRol()
        {
            Console.Write("Nombre usuario: ");
            string n = Console.ReadLine();

            Console.WriteLine("Rol (1=Admin, 2=Editor, 3=Invitado): ");
            int r = int.Parse(Console.ReadLine());

            sistema.AsignarRol(n, (TipoRol)(r - 1));
        }

        static void IniciarSesion()
        {
            Console.Write("Nombre: ");
            string n = Console.ReadLine();

            Console.Write("Password: ");
            string p = Console.ReadLine();

            sistema.IniciarSesion(n, p);
        }
    }
}
