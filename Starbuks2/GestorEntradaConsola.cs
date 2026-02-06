using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorEntradaConsola
    {
        public string OpcionSeleccionada { get; set; }
        private string nombre;
        private string contraseña;
        private int tipoDeMembresia;

        public void GuardarDatosDeEntrada(string opcionEntrada)
        {
            OpcionSeleccionada = opcionEntrada;
        }
    }
}
