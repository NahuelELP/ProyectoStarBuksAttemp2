using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarB3
{
    internal class ServiciosDeDescuento
    {
        private Dictionary<TipoDeMembresia, double> tablaDescuentos = new Dictionary<TipoDeMembresia, double>() //mapa, clave : membresia valor : porcentaje
        {
            { TipoDeMembresia.basic, 0.05 },  // 05% de descuento
            { TipoDeMembresia.green, 0.10 },  // 10% de descuento
            { TipoDeMembresia.gold, 0.15 }    // 15% de descuento
        };
        public double AplicarDescuentos(Carrito carrito, TipoDeMembresia tipoMembresia)
        {
            double subtotal = carrito.CalcularSubTotal();
            double descuento = 0;
            if(tablaDescuentos.ContainsKey(tipoMembresia))
            {
                descuento = tablaDescuentos[tipoMembresia];
            }
            else
            {
                return subtotal;
            }
            double total = subtotal - (subtotal * descuento);
            return total;
        }
    }
}
