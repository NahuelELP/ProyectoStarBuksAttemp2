using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDeUsuarios gestorDeUsuarios = new GestorDeUsuarios(new List<Usuario>());
            GestorDeProductos gestorDeProductos = new GestorDeProductos();
            ServiciosDeDescuento serviciosDeDescuento = new ServiciosDeDescuento();
            gestorDeProductos.AgregarStock(new Producto("Cafe", 0.5));
            gestorDeProductos.AgregarStock(new Producto("Te", 0.3));
            gestorDeProductos.AgregarStock(new Producto("Chocolate", 0.7));
            gestorDeProductos.AgregarStock(new Producto("Muffin", 1.0));
            gestorDeProductos.AgregarStock(new Producto("Galleta", 0.8));
            int input = 0;
            do
            {
                Console.WriteLine("Bienvenido a StarB3");
                Console.WriteLine("1. Iniciar Sesion");
                Console.WriteLine("2. Registrarse");
                Console.WriteLine("3. Salir");
                input = int.Parse(Console.ReadLine());
                string nombre;
                string contraseña;
                int tipoMembresia;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Ingrese su nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su contraseña:");
                        contraseña = Console.ReadLine();
                        if(gestorDeUsuarios.InciarSesion(nombre, contraseña))
                        {
                            Carrito carritoDeUsuario = new Carrito();
                            int input2 = 0;
                            do
                            {
                                Console.WriteLine("1. Ver productos disponibles\n2. Agregar producto al carrito\n3. Quitar producto del carrito" +
                                                  "\n4. Ver SubTotal\n5. Finalizar Compra\n6. Cerrar Sesion");
                                input2 = int.Parse(Console.ReadLine());
                                switch (input2)
                                {
                                    case 1:
                                        gestorDeProductos.ListaProductos().ForEach(x => Console.WriteLine($@"{x.Nombre} ${x.Precio}"));
                                        break;
                                    case 2:
                                        Console.WriteLine("Ingrese el nombre del producto que desea agregar al carrito:");
                                        string nombreProductoAgregar = Console.ReadLine();
                                        Producto productoAgregar = gestorDeProductos.BuscarProductoPorNombre(nombreProductoAgregar);
                                        carritoDeUsuario.AgregarProducto(productoAgregar);
                                        break;
                                    case 3:
                                        Console.WriteLine("Ingrese el nombre del producto que desea quitar del carrito:");
                                        string nombreProductoQuitar = Console.ReadLine();
                                        Producto productoQuitar = gestorDeProductos.BuscarProductoPorNombre(nombreProductoQuitar);
                                        carritoDeUsuario.QuitarProduto(productoQuitar);
                                        break;
                                    case 4:
                                        Console.WriteLine($@"Subtotal: ${carritoDeUsuario.CalcularSubTotal()}");
                                        double subTotalConDescuento = serviciosDeDescuento.AplicarDescuentos(carritoDeUsuario,gestorDeUsuarios.VerTipoMembresia(gestorDeUsuarios.DevolverUsuario(nombre)));
                                        Console.WriteLine($@"Subtotal con descuento: ${subTotalConDescuento}");
                                        break;
                                    case 5:
                                        //falta Finalizar Compra (venta)
                                        break;
                                    default:
                                        input2 = 6;//salir
                                        break;
                                }
                            } while (input2 >= 1 && input2 <=5);
                        }
                        else
                        {
                            Console.WriteLine("Usuario o contraseña incorrectos");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese su nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su contraseña:");
                        contraseña = Console.ReadLine();
                        Console.WriteLine("Ingrese su tipo de membresia (1: Basica, 2: Green, 3: Gold)");
                        tipoMembresia = int.Parse(Console.ReadLine());
                        gestorDeUsuarios.Registrarse(nombre, contraseña, (TipoDeMembresia)tipoMembresia);
                        break;
                    default:
                        break;
                }
            }while (input <= 2);
        }
    }
}
