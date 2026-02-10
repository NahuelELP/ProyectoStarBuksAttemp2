using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class ListaDeUsuarios
    {
        public List<Usuario> ListaDeLosUsuarios { get; }
        public ListaDeUsuarios()
        {
            ListaDeLosUsuarios = new List<Usuario>();
        }
        public void AgregarUsuariosBase()
        {                                                   //Id  membresia
            ListaDeLosUsuarios.Add(new Usuario("admin", "0404", 1, 3));
            ListaDeLosUsuarios.Add(new Usuario("Mati", "2132", 2, 3));
        }
    }
}
