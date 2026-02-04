using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasSOLID
{
    internal class GestorSesion : ISelectorDeInicioSesion
    {
        public string Name { get; set; }
        public string Contraseña { get; set;}
        public void IniciarSesion(string usuario, string contrasena)
        {
            Name = usuario;
            Contraseña = contrasena;
            Console.WriteLine("Inciaste sesion {0}", Name);
        }
        public void CerrarSesion()
        {
            Name = string.Empty;
            Contraseña = string.Empty;
            Console.WriteLine("Se cerro la sesion");
        }
    }
}
