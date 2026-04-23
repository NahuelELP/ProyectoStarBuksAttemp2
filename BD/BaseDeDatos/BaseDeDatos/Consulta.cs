using MySqlConnector;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    internal class Consulta
    {
        public void ConsultaAlumnos()
        {
            Conexion conexionConsulta = new Conexion();
            string consulta = "SELECT * FROM alumnos";
            try
            {
                conexionConsulta.AbrirConexion();
                MySqlCommand comandoConsulta = new MySqlCommand(consulta, conexionConsulta.conexion);
                MySqlDataReader datos = comandoConsulta.ExecuteReader();// execute reader devuelve un objeto de tipo MySqlDataReader que se utiliza para leer los datos devueltos por la consulta
                while (datos.Read())
                {
                    Console.WriteLine($"{datos["id_alumno"]}" +
                        $"{datos["nombre"]}" +
                        $"{datos["apellido"]}" +
                        $"{datos["edad"]}" +
                        $"{datos["direccion"]}" +
                        $"{datos["telefono"]}" +
                        $"{datos["grado"]}" +
                        $"{datos["id_profesor"]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al realizar la consulta " + e);
            }
            finally
            {
                conexionConsulta.CerrarConexion();
            }
        }
    }
}
