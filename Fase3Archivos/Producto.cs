using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3Archivos
{
    internal class Producto
    {
        public string Nombre { get; }
        public double Precio { get; }
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
