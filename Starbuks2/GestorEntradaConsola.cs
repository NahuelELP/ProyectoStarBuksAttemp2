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
        private ListaDeUsuarios listaUsuarios;
        public GestorEntradaConsola(ListaDeUsuarios listaUsuarios)
        {
            this.listaUsuarios = listaUsuarios;
        }
        public void GuardarDatosDeEntrada(string opcionEntrada)
        {
            OpcionSeleccionada = opcionEntrada;
        }
        public void GuardarDatoDeEntradaNombre()
        {
            Console.WriteLine("Nombre:");
            this.nombre = Console.ReadLine();
        }
        public void GuardarDatoDeEntradaContraseña()
        {
            Console.WriteLine("Contraseña");
            this.contraseña = Console.ReadLine();
        }
        public void GuardarDatoDeEntradaMembresia(string tipoMembresia)
        {
            this.tipoDeMembresia = int.Parse(tipoMembresia);
        }
        public void GuardarNuevoUsuario()//GestorEntradaConosola, no deberia agregar usuarios.
        {
            listaUsuarios.ListaDeLosUsuarios.Add(new Usuario(nombre,contraseña, 1, tipoDeMembresia));
        }
    }
}
