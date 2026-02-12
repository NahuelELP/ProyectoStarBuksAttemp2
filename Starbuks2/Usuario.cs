using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class Usuario : ITipoDeMembresia, ITipoUsuario
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Contraseña { get; }
        public UserRoll Roll { get; }
        public int TipoMembresia { get; set; }//enum

        public Usuario(string nombre, string contraseña, int id,UserRoll roll, int tipoMembresia)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Id = id;
            TipoMembresia = tipoMembresia;
            Roll = roll;
        }
    }
}