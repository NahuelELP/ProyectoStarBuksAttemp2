using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDeMostrarConsola gestorConsolola = new GestorDeMostrarConsola();
            gestorConsolola.MostrarEnConsola(new InterfazUsuario());
            gestorConsolola.MostrarEnConsola(new InterfazRegistrarseIniciarSesion());
            gestorConsolola.MostrarEnConsola(new InterfazRegistrarseTipoMembresia());
            gestorConsolola.MostrarEnConsola(new InterfazRegistrarse());
            gestorConsolola.MostrarEnConsola(new InterfazIniciarSesion());
            gestorConsolola.MostrarEnConsola(new InterfazAdmin());
            gestorConsolola.MostrarEnConsola(new InterfazConsolaAdminUsuario());
        }
    }
}
