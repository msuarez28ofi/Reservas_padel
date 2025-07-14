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

            cbxCancha.Items.Clear();
            cbxCancha.Items.Add("Todas");
            cbxCancha.Items.Add("Techada");
            cbxCancha.Items.Add("No techada");
            cbxCancha.SelectedIndex = 0;

            ActualizarFranjasOcupadas();
        }

        private void cbxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cbxCancha.SelectedItem.ToString();

            List<string> techadas = new List<string> { "LaTortuga", "LosFrailes", "LosTestigos" };
            List<string> noTechadas = new List<string> { "Margarita", "Cubagua", "Coche" };

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("bt_"))
                {
                    string[] partes = btn.Name.Split('_');
                    if (partes.Length < 2) continue;

                    string cancha = partes[1];

                    if (tipoSeleccionado == "Todas")
                    {
                        btn.Visible = true;
                    }
                    else if (tipoSeleccionado == "Techada")
                    {
                        btn.Visible = techadas.Contains(cancha);
                    }
                    else if (tipoSeleccionado == "No techada")
                    {
                        btn.Visible = noTechadas.Contains(cancha);
                    }
                }
            }
        }

        private void btnFranja_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Tag == null || btn.Tag.ToString() != "seleccionado")
            {
                btn.Tag = "seleccionado";
                btn.BackColor = Color.FromArgb(64, 64, 64);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.Tag = "";
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;
            }
        }

        private void btReservar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date;

            try
            {
                conex.connnect();

                if (conex.conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Conexión fallida. La conexión no está abierta.");
                    return;
                }

                // Buscar todos los botones seleccionados
                List<Button> botonesSeleccionados = new List<Button>();
                BuscarBotonesSeleccionados(this.Controls, botonesSeleccionados);

                if (botonesSeleccionados.Count == 0)
                {
                    MessageBox.Show("No se seleccionó ninguna franja.");
                    return;
                }

                foreach (Button btn in botonesSeleccionados)
                {
                    string[] partes = btn.Name.Split('_');
                    if (partes.Length < 3)
                    {
                        MessageBox.Show("Nombre del botón inválido: " + btn.Name);
                        continue;
                    }

                    string nombreCancha = partes[1];
                    string franja = btn.Text;

                    string sqlCancha = "SELECT id_Cancha FROM Canchas WHERE Nombre_Cancha = @nombre";
                    MySqlCommand cmdCancha = new MySqlCommand(sqlCancha, conex.conn);
                    cmdCancha.Parameters.AddWithValue("@nombre", nombreCancha);
                    object resultadoCancha = cmdCancha.ExecuteScalar();

                    if (resultadoCancha == null)
                    {
                        MessageBox.Show("No se encontró la cancha en la base: " + nombreCancha);
                        continue;
                    }

                    int idCancha = Convert.ToInt32(resultadoCancha);
                    int idUsuario = Login.idUsuario;

                    if (idUsuario <= 0)
                    {
                        MessageBox.Show("ID de usuario inválido: " + idUsuario);
                        continue;
                    }

                    // Verificar si ya existe la reserva
                    string sqlCheck = "SELECT COUNT(*) FROM Reservas WHERE fecha_reserva = @fecha AND franja_horaria = @franja AND id_Cancha = @cancha";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conex.conn);
                    cmdCheck.Parameters.AddWithValue("@fecha", fecha);
                    cmdCheck.Parameters.AddWithValue("@franja", franja);
                    cmdCheck.Parameters.AddWithValue("@cancha", idCancha);
                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe > 0)
                    {
                        btn.BackColor = Color.LightGray;
                        btn.Enabled = false;
                        btn.Tag = null;
                        MessageBox.Show("Ya reservada: " + nombreCancha + " - " + franja);
                    }
                    else
                    {
                        // Insertar reserva
                        string sqlInsert = "INSERT INTO Reservas (fecha_reserva, franja_horaria, id_Cancha, id_Usuario) VALUES (@fecha, @franja, @cancha, @usuario)";
                        MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conex.conn);
                        cmdInsert.Parameters.AddWithValue("@fecha", fecha);
                        cmdInsert.Parameters.AddWithValue("@franja", franja);
                        cmdInsert.Parameters.AddWithValue("@cancha", idCancha);
                        cmdInsert.Parameters.AddWithValue("@usuario", idUsuario);

                        int filas = cmdInsert.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            btn.BackColor = Color.LightBlue;
                            btn.Enabled = false;
                            btn.Tag = null;
                            MessageBox.Show("Reserva guardada: " + nombreCancha + " - " + franja);
                        }
                        else
                        {
                            MessageBox.Show("Error: No se insertó ninguna fila.");
                        }
                    }
                }

                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reservar: " + ex.Message);
                conex.CerrarConexion();
            }
        }

        private void BuscarBotonesSeleccionados(Control.ControlCollection controles, List<Button> lista)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "seleccionado")
                {
                    lista.Add(btn);
                }
                else if (ctrl.HasChildren)
                {
                    BuscarBotonesSeleccionados(ctrl.Controls, lista); // recursivo
                }
            }
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            MisReservas ver = new MisReservas();
            ver.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarFranjasOcupadas()
        {
            DateTime fecha = dtpFecha.Value.Date;
            conex.connnect();

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("bt_"))
                {

                    // Restaurar botón por defecto antes de verificar si está ocupado
                    btn.Enabled = true;
                    btn.BackColor = SystemColors.Control;
                    btn.ForeColor = Color.Black;
                    btn.Tag = null;

                    string[] partes = btn.Name.Split('_');
                    if (partes.Length < 3) continue;

                    string nombreCancha = partes[1];
                    string franja = btn.Text;

                    string sqlCancha = "SELECT id_Cancha FROM Canchas WHERE Nombre_Cancha = @nombre";
                    MySqlCommand cmdCancha = new MySqlCommand(sqlCancha, conex.conn);
                    cmdCancha.Parameters.AddWithValue("@nombre", nombreCancha);
                    object resultadoCancha = cmdCancha.ExecuteScalar();

                    if (resultadoCancha != null)
                    {
                        int idCancha = Convert.ToInt32(resultadoCancha);

                        string sqlCheck = "SELECT COUNT(*) FROM Reservas WHERE fecha_reserva = @fecha AND franja_horaria = @franja AND id_Cancha = @cancha";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conex.conn);
                        cmdCheck.Parameters.AddWithValue("@fecha", fecha);
                        cmdCheck.Parameters.AddWithValue("@franja", franja);
                        cmdCheck.Parameters.AddWithValue("@cancha", idCancha);

                        int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (existe > 0)
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.FromArgb(64, 64, 64);
                            btn.ForeColor = Color.White;
                        }
                    }
                }
            }

            conex.CerrarConexion();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFranjasOcupadas();
        }
    }
}

