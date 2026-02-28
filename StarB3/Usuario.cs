using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarB3
{
    internal class Usuario
    {
        public string Nombre { get; private set; }
        public string Contraseña { get; }
        public Roll Roll { get; }
        public TipoDeMembresia TipoDeMembresia { get; }

        public Usuario(string nombre, string contraseña, TipoDeMembresia tipoDeMembresia)
        {
            Nombre = nombre;    
            Contraseña = contraseña;
            TipoDeMembresia = tipoDeMembresia;
        }
        public Usuario(string nombre, string contraseña, TipoDeMembresia tipoDeMembresia, Roll roll)//Agregar Id
        {
            Nombre = nombre;
            Contraseña = contraseña;
            TipoDeMembresia = tipoDeMembresia;
            Roll = roll;
        }
    }
}
