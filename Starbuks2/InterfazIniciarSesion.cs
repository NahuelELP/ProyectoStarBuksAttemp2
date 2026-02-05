using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazIniciarSesion : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Inicio de Sesion-",
                "-Nombre:-",
                "-Contraseña:-"
            };
        }
    }
}
/*
 *          Console.WriteLine("-Inicio de Sesion-");
            Console.WriteLine("-Nombre:-");
            Console.WriteLine("-Contraseña:-");
 */
