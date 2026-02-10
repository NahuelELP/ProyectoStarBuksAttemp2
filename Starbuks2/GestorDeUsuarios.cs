using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class GestorDeUsuarios
    {
        private ListaDeUsuarios listaUsuarios;
        private GestorEntradaConsola datosEntradaConsola;

        public GestorDeUsuarios(ListaDeUsuarios listaUsuarios, GestorEntradaConsola datosEntradaConsola)
        {
            this.listaUsuarios = listaUsuarios;
            this.datosEntradaConsola = datosEntradaConsola;
        }
        public void GuardarNuevoUsuario()
        {
            int i = 2;
            listaUsuarios.ListaDeLosUsuarios.Add(new Usuario(datosEntradaConsola.Nombre, datosEntradaConsola.Contraseña, i++, datosEntradaConsola.TipoDeMembresia));
        }
        public bool BuscarUsuario()
        {
            Usuario usuarioEncontradoDatosEntrada = listaUsuarios.ListaDeLosUsuarios.Find(usuario => usuario.Nombre == datosEntradaConsola.Nombre);
            Usuario usuarioEncontradoLista = listaUsuarios.ListaDeLosUsuarios.Find(usuario => usuario.Nombre == "admin");
            if (usuarioEncontradoDatosEntrada != null && usuarioEncontradoLista != null)
            {
                return true;//usuario encontrado
            }
            else
            {
                return false;//usuario no encontrado
            }
            //Buscar el usuario por ID, pensar forma para determinar usuario o admin. setear el valor 1 para admin.
            //generar un numero incrementado dsp de 1 para los siguiente usuarios
        }
        public void AdminOUsuario()
        {
            //setear un valor numero fijo para admin
        }
    }
}
