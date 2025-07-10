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
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            tbCliente.Text = Login.nombreUsuario;
            cbxCancha.SelectedIndex = 0;
        }

        private void cbxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Margarita_830_10_Click(object sender, EventArgs e)
        {

        }

        private void btnFranja_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Tag == null || btn.Tag.ToString() != "seleccionado")
            {
                btn.Tag = "seleccionado";
                btn.BackColor = Color.LightGreen;  // se pinta verde
            }
            else
            {
                btn.Tag = "";
                btn.BackColor = SystemColors.Control; // vuelve al color normal
            }
        }

        private void btReservar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date;

            try
            {
                conex.connnect();

                // Obtener ID del usuario logueado
                string sqlUsuario = "SELECT id_Usuario FROM Usuario WHERE Nombre_Usuario = @nombre";
                MySqlCommand cmdUsuario = new MySqlCommand(sqlUsuario, conex.conn);
                cmdUsuario.Parameters.AddWithValue("@nombre", Login.nombreUsuario);
                int idUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button && ctrl.Tag != null && ctrl.Tag.ToString() == "seleccionado")
                    {
                        Button btn = (Button)ctrl;

                        // Extraer nombre del botón
                        string[] partes = btn.Name.Split('_');
                        if (partes.Length < 4) continue;

                        string canchaNombre = partes[1]; 
                        string franja = btn.Text;        

                        // Obtener ID de la cancha
                        string sqlCancha = "SELECT id_Cancha FROM Canchas WHERE Nombre_Cancha = @cancha";
                        MySqlCommand cmdCancha = new MySqlCommand(sqlCancha, conex.conn);
                        cmdCancha.Parameters.AddWithValue("@cancha", canchaNombre);
                        int idCancha = Convert.ToInt32(cmdCancha.ExecuteScalar());

                        // Verificar si ya está reservada
                        string sqlCheck = "SELECT COUNT(*) FROM Reservas WHERE fecha_reserva = @fecha AND franja_horaria = @franja AND id_Cancha = @idCancha";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conex.conn);
                        cmdCheck.Parameters.AddWithValue("@fecha", fecha);
                        cmdCheck.Parameters.AddWithValue("@franja", franja);
                        cmdCheck.Parameters.AddWithValue("@idCancha", idCancha);
                        int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (existe > 0)
                        {
                            // Ya está ocupada - Desactivar y marcar gris
                            btn.Enabled = false;
                            btn.BackColor = Color.LightGray;
                            btn.Tag = null;
                        }
                        else
                        {
                            // Insertar reserva
                            string sqlInsert = "INSERT INTO Reservas (fecha_reserva, franja_horaria, id_Cancha, id_Usuario) " +
                                               "VALUES (@fecha, @franja, @idCancha, @idUsuario)";
                            MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conex.conn);
                            cmdInsert.Parameters.AddWithValue("@fecha", fecha);
                            cmdInsert.Parameters.AddWithValue("@franja", franja);
                            cmdInsert.Parameters.AddWithValue("@idCancha", idCancha);
                            cmdInsert.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmdInsert.ExecuteNonQuery();

                            // Marcar como reservado 
                            btn.BackColor = Color.LightSkyBlue;
                            btn.Enabled = false;
                            btn.Tag = null;
                        }
                    }
                }

                MessageBox.Show("Reserva(s) procesada(s).");
                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reservar: " + ex.Message);
                conex.CerrarConexion();
            }
        }
    }
}
//prueba para commit 
