using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class Usuario : ITipoDeMembresia
    {
        public string Nombre { get; } // expresion lambda (Nombre => x.Nombre)
        public string Contraseña { get; } // expresion lambda (Contraseña => x.contraseña)
        public int Id { get; } // expresion lambda (ID => x.ID)

        public int Membresia { get; } // expresion lambda (Membresia => x.Membresia)
        public Usuario(string nombre, string contraseña, int id, int membresia)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Id = id;
            Membresia = membresia;
        }
    }
}