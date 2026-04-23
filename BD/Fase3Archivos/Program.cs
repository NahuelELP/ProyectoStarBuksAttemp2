using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>()
            {
                new Producto("Cafe", 2.5),
                new Producto("Te", 1.8),
                new Producto("Brownie", 3.0),
                new Producto("Galleta", 1.2)
            };
            GuardarProductos(productos);
            Console.WriteLine("Ingrese el nombre del nuevo producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del nuevo producto:");
            double precio = double.Parse(Console.ReadLine());
            Producto nuevoProducto = new Producto(nombre, precio);
            GuardarPorductoNuevo(nuevoProducto);
        }
        static void GuardarProductos(List<Producto> productos)
        {
            string ruta = "productos.txt";

            using (StreamWriter writer = new StreamWriter(ruta))
            {
                foreach (var producto in productos)
                {
                    writer.WriteLine($"{producto.Nombre};${producto.Precio}");
                }
            }
        }
        static void GuardarPorductoNuevo(Producto producto)
        {
            string ruta = "productos.txt";
            using (StreamWriter writer = new StreamWriter(ruta, true))
            {
                writer.WriteLine($"{producto.Nombre};${producto.Precio}");
            }
        }
    }
}
