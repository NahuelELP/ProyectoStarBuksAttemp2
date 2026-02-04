using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDeReportes ReporteEmail = new GestorDeReportes(new ReporteEmail());
            ReporteEmail.GenerarReporte("Hola email");
            GestorDeReportes ReporteArchivo = new GestorDeReportes(new ReporteArchivo());
            ReporteArchivo.GenerarReporte("Hola archivo");
            GestorDeReportes ReporteConsola = new GestorDeReportes(new ReporteConsola());
            ReporteConsola.GenerarReporte("Hola consola");
        }
    }
}
/*
    IReporte

    ReporteEmail

    ReporteArchivo

    ReporteConsola

    GeneradorReportes
 */
