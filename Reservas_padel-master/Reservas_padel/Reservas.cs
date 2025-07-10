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
            string tipo = cmbTipo.SelectedItem.ToString();
            cbxCancha.Items.Clear();

            conex.connnect();
            string sql = "";

            if (tipo == "Todas")
                sql = "SELECT Nombre_Cancha FROM Canchas";
            else
                sql = "SELECT Nombre_Cancha FROM Canchas WHERE Tipo_Cancha = @tipo";

            MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
            if (tipo != "Todas")
                cmd.Parameters.AddWithValue("@tipo", tipo);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxCancha.Items.Add(reader.GetString("Nombre_Cancha"));
            }
            reader.Close();
            conex.CerrarConexion();
        }

        private void bt_Margarita_830_10_Click(object sender, EventArgs e)
        {

        }
    }
}

