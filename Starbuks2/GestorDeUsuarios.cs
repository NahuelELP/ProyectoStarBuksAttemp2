using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorDeUsuarios
    {
        private ListaDeUsuarios listaUsuarios;
        private GestorEntradaConsola datosEntradaConsola;
        private Usuario usuario;
        public GestorDeUsuarios(ListaDeUsuarios listaUsuarios, GestorEntradaConsola datosEntradaConsola)
        {
            this.listaUsuarios = listaUsuarios;
            this.datosEntradaConsola = datosEntradaConsola;
        }
        public void GuardarNuevoUsuario()
        {
            listaUsuarios.ListaDeLosUsuarios.Add(new Usuario(datosEntradaConsola.Nombre, datosEntradaConsola.Contraseña, 1, datosEntradaConsola.TipoDeMembresia));
        }
        public void BuscarUsuario()
        {
            //Buscar el usuario por ID, pensar forma para determinar usuario o admin. setear el valor 1 para admin.
            //generar un numero incrementado dsp de 1 para los siguiente usuarios siendo
        }
        public void AdminOUsuario()
        {
            //setear un valor numero fijo para admin
        }
    }
}
