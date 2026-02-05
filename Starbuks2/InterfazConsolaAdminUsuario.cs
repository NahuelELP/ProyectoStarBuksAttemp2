using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazConsolaAdminUsuario : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Seleccion de cuenta-",
                "-Admin- (Presione 1)",
                "-Usuario- (Presione 2)"
            };
        }
    }
}
/*            Console.WriteLine("-Seleccion de cuenta-");
            Console.WriteLine("-Admin- (Presione 1)");
            Console.WriteLine("-Usuario- (Presione 2)");*/
