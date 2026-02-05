using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class MembresiaBasic : ICalcularDescuento
    {
        public double CalcularDescuento(double precio)
        {
            return precio * 0.05; // Aplica un descuento del 5% para la membresía Basic
        }
    }
}
