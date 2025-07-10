using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reservas_padel
{
    public class conex
    {
        public static MySqlConnection conn;
        public static MySqlDataReader Lector;

        public static void connnect()
        {
            try
            {
                string Lineacon = "datasource=localhost; Port=3306; User=root; Password=; database=padel;";

                conn = new MySqlConnection(Lineacon);

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: " + ex.Message);
            }
        }

        public static void EjecutarConsulta(string consultaSQL)
        {
            try
            {
                connnect();
                MySqlCommand cmd = new MySqlCommand(consultaSQL, conn);
                Lector = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
                Lector = null;
            }
        }

        public static void CerrarConexion()
        {
            try
            {
                if (Lector != null && !Lector.IsClosed)
                    Lector.Close();

                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch { }
        }
    }
}

