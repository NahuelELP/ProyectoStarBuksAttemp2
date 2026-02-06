using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfacesDeConsola
    {
        public void MostrarRegistrarseIniciarSesion()//registrarse o iniciar sesion
        {
            Console.WriteLine("1. Registrarse");
            Console.WriteLine("2. Iniciar Sesion");
        }
        public void MostrarSeleccionAdminOUsuario()//seleccion admin o usuario
        {
            Console.WriteLine("1. Usuario");
            Console.WriteLine("2. Admin"); //No implentar
        }
        public void MostrarRegistroDeUsuario()//registro de usuario
        {
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Contraseña");
            Console.WriteLine("3. Membresia");
        }
        public void MostrarInicioDeSesion()//inicio de sesion
        {
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Contraseña");
        }
        public void MostrarTipoDeMembresia()//tipo de membresia
        {
            Console.WriteLine("1. Basic");
            Console.WriteLine("2. Green");
            Console.WriteLine("3. Gold");
        }
        public void MostrarMenuDeUsuario()//menu de usuario
        {
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Borrar producto");
            Console.WriteLine("3. Ver productos");
            Console.WriteLine("4. Ver carrito actual");
            Console.WriteLine("5. finalizar compra");
        }
        public void MostrarMenuDeAdmin()//menu de admin
        {
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Borrar Producto");
            Console.WriteLine("3. Ver Producto/s");
            Console.WriteLine("4. Editar Producto");
        }
    }
}
