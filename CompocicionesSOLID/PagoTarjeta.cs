using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompocicionesSOLID
{
    internal class PagoTarjeta : IPago
    {
        public void Pagar(double monto)
        {
            Console.WriteLine("Pagaste {0} con Tarjeta",monto);
        }
    }
}
