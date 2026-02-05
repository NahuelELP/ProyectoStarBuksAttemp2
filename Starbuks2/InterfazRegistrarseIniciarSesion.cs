using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazRegistrarseIniciarSesion : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Registrarse- (Presione 1)",
                "-Iniciar Sesion- (Presione 2)"
            };
        }
    }
}
/*            Console.WriteLine("-Registrarse- (Presione 1)");
            Console.WriteLine("-Iniciar Sesion- (Presione 2)");*/
