using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class Usuario : ITipoDeMembresia, ITipoUsuario
    {
        public string Nombre { get; }// expresion lambda (Nombre => x.Nombre)
        public string Contraseña { get; } // expresion lambda (Contraseña => x.contraseña)
        public int Id { get; }

        public int TipoMembresia { get; set; }

        public Usuario(string nombre, string contraseña, int id, int tipoMembresia)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Id = id;
            TipoMembresia = tipoMembresia;
        }
    }
}