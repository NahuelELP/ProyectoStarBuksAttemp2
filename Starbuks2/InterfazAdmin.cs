using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuks2
{
    internal class InterfazAdmin : IInterfazDeLaConsola
    {
        public List<string> MostrarEnConsola()
        {
            return new List<string>
            {
                "----------------",
                "-Agregar Producto- (Presione 1)",
                "-Borrar Producto- (Presione 2)",
                "-Ver Producto/s- (Presione 3)",
                "-Editar Producto- (Presione 4)"
            };
        }
    }
}
