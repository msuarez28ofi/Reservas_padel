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

                string query = @"SELECT r.id_Reserva, 
                                r.fecha_reserva AS 'Fecha',
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

                if (dgvMisReservas.Columns.Contains("id_Reserva"))
                    dgvMisReservas.Columns["id_Reserva"].Visible = false;

                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message);
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reservas frm = new Reservas();
            frm.Show();
            this.Close();
        }

        private void btEliminarReserva_Click(object sender, EventArgs e)
        {
            if (dgvMisReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar esta reserva?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                int idReserva = Convert.ToInt32(dgvMisReservas.SelectedRows[0].Cells["id_Reserva"].Value);

                conex.connnect();

                string sql = "DELETE FROM Reservas WHERE id_Reserva = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                cmd.Parameters.AddWithValue("@id", idReserva);
                cmd.ExecuteNonQuery();

                conex.CerrarConexion();

                MessageBox.Show("Reserva eliminada exitosamente.");
                MisReservas_Load(null, null); // recargar la tabla
            }

        }
    }
}
