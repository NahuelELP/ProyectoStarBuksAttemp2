using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorDeMostrarConsola
    {
        public void MostrarEnConsola(IInterfazDeLaConsola interfaz)
        {
            foreach (string interfazConsola in interfaz.MostrarEnConsola())
            {
                Console.WriteLine(interfazConsola);
            }
        }
    }
}
