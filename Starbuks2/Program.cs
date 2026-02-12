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
            List<Membresia> membresias = new List<Membresia>();//lista de membresias
            List<Usuario> listaDeUsuarios = new List<Usuario>();//lista de usuarios
            InterfacesDeConsola interfacesDeConsola = new InterfacesDeConsola();
            GestorEntradaConsola gestorEntradaConsola = new GestorEntradaConsola();
            GestorDeUsuarios gestorUsuarios = new GestorDeUsuarios(listaDeUsuarios, gestorEntradaConsola);
            AgreagarUsuariosBase(listaDeUsuarios);//usuarios base
            AgregarMemebresiasBase(membresias);//eliminar
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
                        //guradar datos de inicio de sesion 
                        if (gestorUsuarios.BuscarUsuario())
                        {
                            Console.WriteLine("Usuario Encontrado");
                            if(gestorUsuarios.AdminOUsuario())
                            {
                                interfacesDeConsola.MostrarMenuDeAdmin();
                            }
                            else
                            {
                                interfacesDeConsola.MostrarMenuDeUsuario();
                                gestorEntradaConsola.GuardarDatoDeEntradaMenu();
                            }
                            //Guardar dato de entrada para menu de usuario y mostrar menu de usuario
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
            usuarios.Add(new Usuario("admin" ,"0404",1 ,UserRoll.Admin ,3));
            usuarios.Add(new Usuario("Mati" ,"2132" ,2 ,UserRoll.Normal ,3));
        }
        static void AgregarMemebresiasBase(List<Membresia> membresias)
        {
            membresias.Add(new Membresia() { TipoMembresia = 1 });//eliminar
            membresias.Add(new Membresia() { TipoMembresia = 2 });
            membresias.Add(new Membresia() { TipoMembresia = 3 });
        }
        static void AgregarProductosStock(List<Producto> productos)
        {
            productos.Add(new Producto("cafe",0.5));
            productos.Add(new Producto("Capuccino", 0.5));
            productos.Add(new Producto("Frappuccino", 0.5));
            productos.Add(new Producto("cafe con leche", 0.5));
            productos.Add(new Producto("cafe lagrima", 0.5));
        }
    }
}
/*foreach(Usuario usu in listaDeUsuarios.ListaDeLosUsuarios)
                    {
                        Console.WriteLine(usu.Nombre);
                        Console.WriteLine(usu.Contraseña);
                        Console.WriteLine(usu.TipoMembresia);
                        Console.WriteLine(usu.Id);
                    }*/
