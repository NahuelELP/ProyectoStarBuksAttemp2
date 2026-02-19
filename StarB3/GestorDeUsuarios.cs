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
    }
}
