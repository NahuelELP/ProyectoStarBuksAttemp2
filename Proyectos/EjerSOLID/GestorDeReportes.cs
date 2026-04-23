using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerSOLID
{
    internal class GestorDeReportes
    {
        private IReporte reporte;
        public GestorDeReportes(IReporte reporte)
        {
            this.reporte = reporte;
        }
        public void GenerarReporte(string mensaje)
        {
            reporte.Enviar(mensaje);
        }
    }
}
