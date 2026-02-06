using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class ListaDeMembresias
    {
        public List<Membresia> ListaDeLasMembresias;
        public ListaDeMembresias()
        {
            ListaDeLasMembresias = new List<Membresia>();
        }
        public void AgregarMemebresiasBase()
        {                                                   
            ListaDeLasMembresias.Add(new Membresia() { TipoMembresia = 1 });
            ListaDeLasMembresias.Add(new Membresia() { TipoMembresia = 2 });
            ListaDeLasMembresias.Add(new Membresia() { TipoMembresia = 3 });
        }
    }
}
