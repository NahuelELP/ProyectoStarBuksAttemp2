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
                                Console.WriteLine("entraste al menu de usuario");
                                Console.ReadKey();
                                /*
                                   1 Ver productos disponibles

                                   2 Agregar producto al carrito

                                   3 Quitar producto del carrito

                                   4 Ver subtotal

                                   5 Finalizar compra

                                   6 Cerrar sesión
                                 */
                            } while (input2 <= 6);
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
