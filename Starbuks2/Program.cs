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
            InterfacesDeConsola interfacesDeConsola = new InterfacesDeConsola();
            GestorEntradaConsola gestorEntradaConsola = new GestorEntradaConsola();
            interfacesDeConsola.MostrarRegistrarseIniciarSesion();
            gestorEntradaConsola.GuardarDatosDeEntrada(Console.ReadLine());
            switch (gestorEntradaConsola.OpcionSeleccionada)
            {
                case "1":
                    interfacesDeConsola.MostrarRegistroDeUsuario();
                    //guardar datos de registro
                    interfacesDeConsola.MostrarTipoDeMembresia();
                    //guardar tipo de membresia
                    //volver al menu principal do wghile
                    break;
                case "2":
                    interfacesDeConsola.MostrarInicioDeSesion();
                    //guradar datos de inicio de sesion
                    interfacesDeConsola.MostrarMenuDeUsuario();
                    break;
            }
        }
    }
}
