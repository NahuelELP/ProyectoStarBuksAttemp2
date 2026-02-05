using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class MembresiaGold : ICalcularDescuento
    {
        public double CalcularDescuento(double precio)
        {
            return precio * 0.20; // Aplica un descuento del 20% para la membresía Gold
        }
    }
}
