using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasSOLID
{
    internal class UsuarioAdministrador : ICerrarSesion
    {
        public void CerrarSesion()
        {
            Console.WriteLine("cerrar sesion admin");
        }
    }
}
