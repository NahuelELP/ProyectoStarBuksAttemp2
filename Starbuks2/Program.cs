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
            List<Usuario> listaDeUsuarios = new List<Usuario>();
            InterfacesDeConsola interfacesDeConsola = new InterfacesDeConsola();
            GestorEntradaConsola gestorEntradaConsola = new GestorEntradaConsola();
            GestorDeUsuarios gestorUsuarios = new GestorDeUsuarios(listaDeUsuarios, gestorEntradaConsola);
            AgreagarUsuariosBase(listaDeUsuarios);//usuarios base
            interfacesDeConsola.MostrarRegistrarseIniciarSesion();
            gestorEntradaConsola.GuardarDatosDeEntrada(Console.ReadLine());
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
                    //volver al menu principal do while
                    break;
                case "2"://iniciar sesion
                    interfacesDeConsola.MostrarInicioDeSesion();
                    //guardar datos de inicio de sesion
                    gestorEntradaConsola.GuardarDatoDeEntradaNombre();
                    gestorEntradaConsola.GuardarDatoDeEntradaContraseña();
                    //guradar datos de inicio de sesion 
                    if (gestorUsuarios.BuscarUsuario())
                    {
                        interfacesDeConsola.MostrarMenuDeUsuario();
                    }
                    break;
            }
        }
        static void AgreagarUsuariosBase(List<Usuario> usuarios)//Static: 
        {
            usuarios.Add(new Usuario("admin", "0404", 1, 3));
            usuarios.Add(new Usuario("Mati", "2132", 2, 3));
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
