using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorDeProductos
    {
        private string nombre;
        private double precio;
        private Producto productoEncontrado;
        private List<Producto> listaProductos;
        public GestorDeProductos(List<Producto> listaProductos)
        {
            this.listaProductos = listaProductos;
        }
        public void AgregarProducto()
        {
            Console.WriteLine("Nombre del nuevo producto:");
            nombre = Console.ReadLine();
            Console.WriteLine("Precio del nuevo producto:");
            precio = double.Parse(Console.ReadLine());
            listaProductos.Add(new Producto(nombre, precio));
        }
        public void EliminarProducto()
        {
            Console.WriteLine("Nombre del producto para eliminar:");
            nombre = Console.ReadLine();
            productoEncontrado = listaProductos.Find(x => x.Nombre == nombre);
            listaProductos.Remove(productoEncontrado);
            Console.WriteLine("Producto eliminado");
        }
        public void VerProductos()
        {
            foreach (Producto producto in listaProductos)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(producto.Nombre);
                Console.WriteLine(producto.Precio);
            }
        }
        public void EditarProducto()
        {
            Console.WriteLine("Nombre del prodcuto para editar:");
            nombre = Console.ReadLine();
            productoEncontrado = listaProductos.Find(x => x.Nombre == nombre);
            Console.WriteLine("Editar precio de {0}:", nombre);
            productoEncontrado.Precio = double.Parse(Console.ReadLine());
        }
    }
}
