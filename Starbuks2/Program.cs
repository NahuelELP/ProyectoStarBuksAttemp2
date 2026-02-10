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
            ListaDeUsuarios listaDeUsu = new ListaDeUsuarios();
            InterfacesDeConsola interfacesDeConsola = new InterfacesDeConsola();
            GestorEntradaConsola gestorEntradaConsola = new GestorEntradaConsola();
            GestorDeUsuarios gestorUsuarios = new GestorDeUsuarios(listaDeUsu,gestorEntradaConsola);
            interfacesDeConsola.MostrarRegistrarseIniciarSesion();
            gestorEntradaConsola.GuardarDatosDeEntrada(Console.ReadLine());
            switch (gestorEntradaConsola.OpcionSeleccionada)
            {
                case "1"://registrarse
                    interfacesDeConsola.MostrarRegistroDeUsuario();
                    gestorEntradaConsola.GuardarDatoDeEntradaNombre();
                    gestorEntradaConsola.GuardarDatoDeEntradaContraseña();
                    //guardar datos de registro
                    interfacesDeConsola.MostrarTipoDeMembresia();
                    gestorEntradaConsola.GuardarDatoDeEntradaMembresia();
                    gestorUsuarios.GuardarNuevoUsuario();
                    //volver al menu principal do wghile
                    break;
                case "2"://iniciar sesion
                    interfacesDeConsola.MostrarInicioDeSesion();//nueva clase ke revice en la lista actual de usuarios si el usuario existe y verificar datos
                    //guradar datos de inicio de sesion 
                    interfacesDeConsola.MostrarMenuDeUsuario();
                    break;
            }
        }
    }
}
/*foreach(Usuario usu in listaDeUsu.ListaDeLosUsuarios)
                    {
                        Console.WriteLine(usu.Nombre);
                        Console.WriteLine(usu.Contraseña);
                        Console.WriteLine(usu.TipoMembresia);
                        Console.WriteLine(usu.Id);
                    }*/
