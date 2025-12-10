using Examen_Unidad4y5.Modelos;
using Examen_Unidad4y5.Patrones.Decorator;
using Examen_Unidad4y5.Patrones.Factory;
using Examen_Unidad4y5.Patrones.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4y5.Fachada
{
    public class SistemaAccesoFacade
    {
        public IEstadoSesion Estado { get; set; } = new EstadoNoAutenticado();
        public Usuario UsuarioActual { get; private set; }

        public void RegistrarUsuario(string nombre, string password, ConsoleColor color)
        {
            RepositorioUsuarios.Usuarios.Add(new Usuario
            {
                Nombre = nombre,
                Password = password,
                ColorTexto = color
            });

            Console.WriteLine("Usuario registrado.");
        }

        public void AsignarRol(string nombre, TipoRol rol)
        {
            var u = RepositorioUsuarios.Usuarios.FirstOrDefault(x => x.Nombre == nombre);
            if (u != null)
            {
                u.Roles.Add(rol);
                Console.WriteLine($"Rol {rol} asignado a {nombre}");
            }
        }

        public bool IniciarSesion(string nombre, string password)
        {
            var u = RepositorioUsuarios.Usuarios.FirstOrDefault(x => x.Nombre == nombre && x.Password == password);

            if (u == null)
            {
                Console.WriteLine("Credenciales incorrectas.");
                return false;
            }

            UsuarioActual = u;
            Estado = new EstadoAutenticado();
            Console.WriteLine($"Bienvenido {u.Nombre}");
            return true;
        }

        public void CerrarSesion()
        {
            Estado = new EstadoSesionFinalizada();
            UsuarioActual = null;
        }

        public void MostrarAcceso()
        {
            if (UsuarioActual == null)
            {
                Estado.Manejar(this);
                return;
            }

            Console.ForegroundColor = UsuarioActual.ColorTexto;

            IUsuarioAcceso usuarioDecorado = new UsuarioBase();

            foreach (var rol in UsuarioActual.Roles)
                usuarioDecorado = RolFactory.CrearDecorador(rol, usuarioDecorado);

            usuarioDecorado.Acceder();

            Console.ResetColor();
        }
    }
}
