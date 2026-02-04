using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasSOLID
{
    internal class UsuarioNormal : ISelectorDeInicioSesion
    {
        private GestorSesion sesion;
        public string Name => sesion.Name;//devuelve el nombre del usuario de la sesion que nosotros le indicamos, diferente a {get;} que solo devuelve el valor
        public string Contraseña => sesion.Contraseña;//devuelve la contraseña del usuario de la sesion
        public UsuarioNormal(GestorSesion gestor)
        {   
            sesion = gestor;
        }
        public void IniciarSesion(string usuario, string contrasena)
        {
            sesion.IniciarSesion(usuario, contrasena);
        }
        public void CerrarSesion()
        {
            sesion.CerrarSesion();
        }
        public string ObtenerNombreUsuario()
        {
            return Name;
        }
        public string ObtenerContraseñaUsuario()
        {
            return Contraseña;
        }
    }
}
