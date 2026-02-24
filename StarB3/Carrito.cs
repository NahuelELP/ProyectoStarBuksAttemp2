using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarB3
{
    internal class Carrito
    {
        private List<Producto> listaDeProductosEnCarrito = new List<Producto>();
        public void AgregarProducto(Producto producto)
        {
            listaDeProductosEnCarrito.Add(producto);
        }
        public void QuitarProduto(Producto producto)
        {
            listaDeProductosEnCarrito.Remove(producto);
        }
        public double CalcularSubTotal()
        {
            double subtotal = 0;
            foreach (Producto x in listaDeProductosEnCarrito)
            {
                subtotal += x.Precio;
            }
            return subtotal;
        }
        public void VaciarCarrito()
        {
            listaDeProductosEnCarrito.Clear();
        }
        public void ListaDeCarrito()
        {
            foreach (Producto x in listaDeProductosEnCarrito)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($@"{x.Nombre}--${x.Precio}");
                Console.WriteLine("----------------");
            }
        }
    }
}
