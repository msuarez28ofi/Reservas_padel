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
    public partial class DatosPago : Form
    {
        int metodoID;
        decimal monto;
        DateTime fecha;

        public DatosPago(int idMetodo, decimal montoUSD, DateTime fechaSeleccionada)
        {
            InitializeComponent();
            metodoID = idMetodo;
            monto = montoUSD;
            fecha = fechaSeleccionada;
        }
        public DatosPago()
        {
            InitializeComponent();
        }

        private void DatosPago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación visual
            if (tbDNI.Text == "" || tbBanco.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                conex.connnect();

                string sql = @"INSERT INTO Pagos (id_usuario, id_metodo_pago, monto_total, fecha_pago)
                       VALUES (@usuario, @metodo, @monto, @fecha)";

                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                cmd.Parameters.AddWithValue("@usuario", Login.idUsuario);
                cmd.Parameters.AddWithValue("@metodo", metodoID);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.ExecuteNonQuery();

                conex.CerrarConexion();

                MessageBox.Show("¡Pago registrado correctamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pago: " + ex.Message);
            }
        }
    }
}
