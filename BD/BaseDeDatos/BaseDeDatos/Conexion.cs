using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class Conexion
    {
        public MySqlConnection conexion { get; set; }
        private string cadenaConexion;
        public Conexion()
        {
            cadenaConexion = "server=localhost;port=3306;" +
                "database=colegio_amanecer;" +
                "user=root;password=TuClaveNueva123!;";
            conexion = new MySqlConnection(cadenaConexion);
        }
        public MySqlConnection AbrirConexion()
        {
            try
            {                           //verifica si la conexion esta cerrada para abrirla
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    Console.WriteLine("Conexion existosa");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error al conectar a la base " + e);
            }
            return conexion;
        }
        public void CerrarConexion()
        {                        // verifica si la conexion esta abierta para cerrarla
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("Conexion cerrada");
            }
             
        }
    }
    
}
