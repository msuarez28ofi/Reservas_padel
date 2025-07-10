using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reservas_padel
{
    public partial class MisReservas : Form
    {
        public MisReservas()
        {
            InitializeComponent();
        }

        private void MisReservas_Load(object sender, EventArgs e)
        {
            CargarReservasDelUsuario();
        }

        private void dtwMisReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarReservasDelUsuario()
        {
            try
            {
                conex.connnect();

                string query = @"SELECT r.fecha_reserva AS 'Fecha',
                                        r.franja_horaria AS 'Franja Horaria',
                                        c.Nombre_Cancha AS 'Cancha'
                                 FROM Reservas r
                                 INNER JOIN Canchas c ON r.id_Cancha = c.id_Cancha
                                 INNER JOIN Usuario u ON r.id_Usuario = u.id_Usuario
                                 WHERE u.Nombre_Usuario = @nombre
                                 ORDER BY r.fecha_reserva";

                MySqlCommand cmd = new MySqlCommand(query, conex.conn);
                cmd.Parameters.AddWithValue("@nombre", Login.nombreUsuario);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvMisReservas.DataSource = dt;
                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
