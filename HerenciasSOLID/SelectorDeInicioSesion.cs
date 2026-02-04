using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasSOLID
{
    internal interface ISelectorDeInicioSesion : IIniciarSesion, ICerrarSesion
    {
        string Name { get; } // Las clases que hereden esta interfaz no se ven obligadas a implementar los setters
        string Contraseña { get;}
    }
}
