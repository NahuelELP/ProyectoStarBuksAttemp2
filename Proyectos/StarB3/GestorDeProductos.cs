using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StarB3
{
    internal class GestorDeProductos
    {
        private List<Producto> products = new List<Producto>();
        public List<Producto> ListaProductos()
        {
            return products;
        }
        public Producto BuscarProductoPorNombre(string nombre)
        {
            Producto productoEncontrado = products.Find(x => x.Nombre == nombre);
            return productoEncontrado;
        }
        public Producto CrearProducto(string nombre, double precio)
        {
            Producto productoCreado = new Producto(nombre, precio);
            return productoCreado;
        }
        public void AgregarStock(Producto producto)
        {
            products.Add(producto);
        }
        public void EliminarStock(Producto producto)
        {
            products.Remove(producto);
        }
        public void EditarProductoStock(Producto producto, double precio)
        {
            Producto productoEditado = producto;
            productoEditado.Precio = precio;
        }
    }
}
