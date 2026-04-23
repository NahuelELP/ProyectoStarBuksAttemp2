using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace BaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conexion conexion = new Conexion();
                Consulta consulta = new Consulta();
                consulta.ConsultaAlumnos();
                Console.ReadKey();
        }
    }
}
