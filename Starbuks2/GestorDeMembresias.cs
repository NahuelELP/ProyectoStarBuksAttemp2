using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorDeMembresias
    {
        private ICalcularDescuento calcularDescuentoMembresia;
        public GestorDeMembresias(ICalcularDescuento calcularDescuentoMembresia)
        {
            this.calcularDescuentoMembresia = calcularDescuentoMembresia;
        }
        public void RealizarDescuento(double precio)
        {
            calcularDescuentoMembresia.CalcularDescuento(precio);
        }
    }
}
