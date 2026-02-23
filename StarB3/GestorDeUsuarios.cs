using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarB3
{
    internal class GestorDeUsuarios
    {
        private List<Usuario> usuarios;
        public GestorDeUsuarios(List<Usuario> usuarios)
        {
            this.usuarios = usuarios;
        }
        public bool InciarSesion(string nombre, string contraseña)
        {
            Usuario usuarioEncontrado = usuarios.Find(x => x.Nombre == nombre && x.Contraseña == contraseña);
            if (usuarioEncontrado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Usuario Registrarse(string nombre, string contraseña, TipoDeMembresia tipoMembresia)
        {
            Usuario UsuarioRegistrado = new Usuario(nombre, contraseña, tipoMembresia);
            usuarios.Add(UsuarioRegistrado);
            return UsuarioRegistrado;
        }
        public void EliminarUsuario(Usuario usuario)
        {
            usuarios.Remove(usuario);
        }
        public Usuario DevolverUsuario(string nombre)
        {
            Usuario usuaruiEncontrado = usuarios.Find(x => x.Nombre == nombre);
            return usuaruiEncontrado;
        }
        public TipoDeMembresia VerTipoMembresia(Usuario usuario)
        {
            foreach (Usuario x in usuarios)
            {
                if (x.Nombre == usuario.Nombre)
                {
                    return x.TipoDeMembresia;
                }
            }
            return TipoDeMembresia.normal;
        }
    }
}
