using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazUsuario : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Bienvenido Usuario-",
                "-1. Ver Menu-",
                "-2. Realizar Pedido-",
                "-3. Ver Historial de Pedidos-",
                "-4. Cerrar Sesion-"
            };
        }
    }
}
/*
 *          Console.WriteLine("----------------");
            Console.WriteLine("-Agregar productos al carrito- (Presione 1)");
            Console.WriteLine("-Borrar Producto del carrito- (Presione 2)");
            Console.WriteLine("-Ver Producto/s- (Presione 3)");
            Console.WriteLine("-Ver carrito actual- (Presione 4)");
            Console.WriteLine("-Buscar/Filtrar productos- (Presione 5)");
            Console.WriteLine("-Finalizar compra- (Presione 6)");
            Console.WriteLine("-Salir- (Presione 7)");
 */
