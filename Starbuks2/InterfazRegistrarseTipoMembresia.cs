using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazRegistrarseTipoMembresia : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Seleccion de membresia-",
                "-Basica- (Presione 1)",
                "-Premium- (Presione 2)"
            };
        }
    }
}
/*            Console.WriteLine("-Seleccion de membresia-");
            Console.WriteLine("-Basica- (Presione 1)");
            Console.WriteLine("-Premium- (Presione 2)");*/
