using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorSesion gestor = new GestorSesion();
            UsuarioCreador creador = new UsuarioCreador(new GestorSesion());
            UsuarioNormal normal = new UsuarioNormal(new GestorSesion());

            creador.IniciarSesion("CreadorUser", "CreadorPass");
            Console.WriteLine(creador.ObtenerNombreUsuario());
            Console.WriteLine(creador.ObtenerContraseñaUsuario());

            normal.IniciarSesion("NormalUser", "NormalPass");
            Console.WriteLine(normal.ObtenerNombreUsuario());
            Console.WriteLine(normal.ObtenerContraseñaUsuario());
        }
    }
}
