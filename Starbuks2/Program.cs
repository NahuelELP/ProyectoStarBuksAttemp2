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
            GestorEntradaConsola gestorEntradaConsola = new GestorEntradaConsola(listaDeUsu);
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
                    gestorEntradaConsola.GuardarDatoDeEntradaMembresia(Console.ReadLine());
                    gestorEntradaConsola.GuardarNuevoUsuario();//clase nueva ke se encargue de guardar el usuario nuevo en la lista de usuarios
                    //guardar tipo de membresia
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
