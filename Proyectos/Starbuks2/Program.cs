using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> ProductosEnCarrito = new List<Producto>();//carrito de compras
            List<Producto> productos = new List<Producto>();//lista de productos
            List<Usuario> listaDeUsuarios = new List<Usuario>();//lista de usuarios
            Carrito carrito = new Carrito(productos);
            GestorDeProductos gestorDeProductos = new GestorDeProductos(productos);
            InterfacesDeConsola interfacesDeConsola = new InterfacesDeConsola();
            GestorEntradaConsola gestorEntradaConsola = new GestorEntradaConsola();
            GestorDeUsuarios gestorUsuarios = new GestorDeUsuarios(listaDeUsuarios, gestorEntradaConsola);
            AgreagarUsuariosBase(listaDeUsuarios);//usuarios base
            AgregarProductosStock(productos);//productos base
            do
            {
                interfacesDeConsola.MostrarRegistrarseIniciarSesion();
                gestorEntradaConsola.GuardarDatosDeEntrada(Console.ReadLine());
                Console.Clear();
                switch (gestorEntradaConsola.OpcionSeleccionada)
                {
                    case "1"://registrarse
                        interfacesDeConsola.MostrarRegistroDeUsuario();
                        gestorEntradaConsola.GuardarDatoDeEntradaNombre();
                        gestorEntradaConsola.GuardarDatoDeEntradaContraseña();
                        interfacesDeConsola.MostrarTipoDeMembresia();
                        //guardar datos de registro
                        gestorEntradaConsola.GuardarDatoDeEntradaMembresia();
                        gestorUsuarios.GuardarNuevoUsuario();
                        Console.Clear();
                        //volver al menu principal do while
                        break;
                    case "2"://iniciar sesion
                        interfacesDeConsola.MostrarInicioDeSesion();
                        //guardar datos de inicio de sesion
                        gestorEntradaConsola.GuardarDatoDeEntradaNombre();
                        gestorEntradaConsola.GuardarDatoDeEntradaContraseña();
                        Console.Clear();
                        if (gestorUsuarios.BuscarUsuario())
                        {
                            Console.WriteLine("Usuario Encontrado");
                            if(gestorUsuarios.AdminOUsuario())
                            {
                                int input;
                                do 
                                {
                                    interfacesDeConsola.MostrarMenuDeAdmin();
                                    input = int.Parse(Console.ReadLine());
                                    switch (input)
                                    {
                                        case 1:
                                            gestorDeProductos.AgregarProducto();
                                            break;
                                        case 2:
                                            gestorDeProductos.EliminarProducto();
                                            break;
                                        case 3:
                                            gestorDeProductos.VerProductos();
                                            break;
                                        case 4:
                                            gestorDeProductos.EditarProducto();
                                            break;
                                        default:
                                            Console.WriteLine("Salir...");
                                            break;
                                    }
                                } while (input < 5);
                            }
                            else
                            {
                                int input;
                                do
                                {
                                    interfacesDeConsola.MostrarMenuDeUsuario();
                                    input = int.Parse(Console.ReadLine());
                                    switch (input)
                                    {
                                        case 1://ver productos lista
                                            carrito.VerProdutos();
                                            carrito.AgregarProducto(Console.ReadLine());
                                            break;
                                        case 2://eliminar producto del carrito
                                            
                                            break;
                                        case 3://ver carrito actual

                                            break;
                                        case 4://finalizar compra

                                            break;
                                        default:
                                            Console.WriteLine("Salir...");
                                            break;
                                    }
                                } while (input < 5);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Usuario o contraseña incorrectos");
                        }
                        break;
                }
            } while (gestorEntradaConsola.OpcionSeleccionada == "1" || gestorEntradaConsola.OpcionSeleccionada == "2");
        }
        static void AgreagarUsuariosBase(List<Usuario> usuarios)
        {
            usuarios.Add(new Usuario("admin" ,"0404",1 ,UserRoll.Admin , TipoMembresia.Gold));
            usuarios.Add(new Usuario("Mati" ,"2132" ,2 ,UserRoll.Normal ,TipoMembresia.Basic));
        }
        static void AgregarProductosStock(List<Producto> productos)
        {
            productos.Add(new Producto("cafe",0.5));
            productos.Add(new Producto("Capuccino", 0.8));
            productos.Add(new Producto("Frappuccino", 1.2));
            productos.Add(new Producto("cafe con leche", 0.9));
            productos.Add(new Producto("cafe lagrima", 0.6));
        }
    }
}
