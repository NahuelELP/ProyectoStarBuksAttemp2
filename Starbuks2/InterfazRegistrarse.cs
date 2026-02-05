using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazRegistrarse : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Registrarse-",
                "-Nombre:-",
                "-Contraseña:-",
                "-Tipo de Membresia:-"
            };
        }
    }
}
/*
 *          Console.WriteLine("-Registro de Usuario-");
            Console.WriteLine("-Nombre:-");
            Console.WriteLine("-Contraseña:-");
            Console.WriteLine("-Tipo de Membresia:-");
 */
