using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerSOLID
{
    internal class ReporteConsola : IReporte
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Reporte enviado a la consola: " + mensaje);
        }
    }
}
