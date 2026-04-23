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
        private List<Usuario> listaUsuarios;
        private GestorEntradaConsola datosEntradaConsola;
        private Usuario usuarioLogeado;

        public GestorDeUsuarios(List<Usuario> listaUsuarios, GestorEntradaConsola datosEntradaConsola)
        {
            this.listaUsuarios = listaUsuarios;
            this.datosEntradaConsola = datosEntradaConsola;
        }
        public void GuardarNuevoUsuario()
        {
            int i = 2;
            listaUsuarios.Add(new Usuario(datosEntradaConsola.Nombre, datosEntradaConsola.Contraseña, i++, UserRoll.Normal, datosEntradaConsola.TipoMembresia));
        }
        public bool BuscarUsuario()
        {
            usuarioLogeado = listaUsuarios.Find(usuario => usuario.Nombre == datosEntradaConsola.Nombre && usuario.Contraseña == datosEntradaConsola.Contraseña);
            if (usuarioLogeado != null)
            {
                return true;//usuario encontrado
            }
            else
            {
                return false;//usuario no encontrado
            }
        }
        public bool AdminOUsuario()
        {
            usuarioLogeado = listaUsuarios.Find(usuario => usuario.Nombre == datosEntradaConsola.Nombre && usuario.Contraseña == datosEntradaConsola.Contraseña);
            if (usuarioLogeado.Roll == UserRoll.Admin)
            {
                return true;//usuario admin 
            }
            else
            {
                return false;//usuario normal
            }
        }
    }
}
