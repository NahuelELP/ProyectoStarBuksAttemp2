using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class Carrito
    {
        private List<Producto> productos;
        public Carrito(List<Producto>productos)
        {
            this.productos = productos;
        }
        public void VerProdutos()
        {
            int i = 1;
            foreach (Producto producto in productos)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("{0}. {1} | {2}$",i++, producto.Nombre, producto.Precio);
            }
        }
        public void AgregarProducto(string opcion)
        {

        }
    }
}
