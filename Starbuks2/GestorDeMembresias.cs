using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorDeMembresias
    {
        private ITipoDeMembresia Membresia;
        public GestorDeMembresias(ITipoDeMembresia membresia)
        {
            Membresia = membresia;
        }
        public void GetTipoDeMembresia()
        {
            Console.WriteLine("Tipo de membresia: {0}", Membresia.TipoMembresia);
        }
    }
}
