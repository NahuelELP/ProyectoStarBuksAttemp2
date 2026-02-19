using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorEntradaConsola
    {
        public string OpcionSeleccionada { get; private set; }
        public string Nombre { get; set; }
        public string Contraseña { get; private set; }
        public TipoMembresia TipoMembresia { get; private set; }
        public int Roll { get; set; }
        public void GuardarDatosDeEntrada(string opcionEntrada)
        {
            OpcionSeleccionada = opcionEntrada;
        }
        public void GuardarDatoDeEntradaNombre()
        {
            Console.WriteLine("Nombre:");
            Nombre = Console.ReadLine();
        }
        public void GuardarDatoDeEntradaContraseña()
        {
            Console.WriteLine("Contraseña");
            Contraseña = Console.ReadLine();
        }
        public void GuardarDatoDeEntradaMembresia()
        {
            Console.WriteLine("Tipo membresia:");
            int input = int.Parse(Console.ReadLine());
            TipoMembresia membresiaSeleccionada = (TipoMembresia)input;
        }
        public void GuardarDatoDeEntradaMenu()
        {
            Console.WriteLine("Opcion: (SELECCIONE NUMERO)");
            OpcionSeleccionada = Console.ReadLine();
        }
    }
}
