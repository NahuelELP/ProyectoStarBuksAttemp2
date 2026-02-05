using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class MembresiaGreen : ICalcularDescuento
    {
        public double CalcularDescuento(double precio)
        {
            return precio * 0.10; // Aplica un descuento del 10% para la membresía Green
        }
    }
}
