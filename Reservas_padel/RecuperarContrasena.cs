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
    public partial class RecuperarContrasena : Form
    {
        public RecuperarContrasena()
        {
            InitializeComponent();
        }

        private void RecuperarContrasena_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = tbCorreo.Text.Trim();
            string telefono = tbTelefono.Text.Trim();
            string codigo = tbCodigo.Text.Trim(); // No hace nadaaaa
            string nueva = tbNuevaContrasena.Text.Trim();

            if (correo == "" || telefono == "" || codigo == "" || nueva == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (nueva.Length < 8)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres.");
                return;
            }

            try
            {
                conex.connnect();

                // Verificar si existe usuario con ese correo y teléfono
                string consulta = "SELECT COUNT(*) FROM Usuario WHERE Correo_Usuario = @correo AND Telefono_Usuario = @telefono";
                MySqlCommand cmdCheck = new MySqlCommand(consulta, conex.conn);
                cmdCheck.Parameters.AddWithValue("@correo", correo);
                cmdCheck.Parameters.AddWithValue("@telefono", telefono);
                int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (existe == 0)
                {
                    MessageBox.Show("No se encontró un usuario con ese correo y teléfono.");
                    conex.CerrarConexion();
                    return;
                }

                // Actualizar la contraseña
                string sql = "UPDATE Usuario SET Contrasena_Usuario = @nueva WHERE Correo_Usuario = @correo AND Telefono_Usuario = @telefono";
                MySqlCommand cmdUpdate = new MySqlCommand(sql, conex.conn);
                cmdUpdate.Parameters.AddWithValue("@nueva", nueva);
                cmdUpdate.Parameters.AddWithValue("@correo", correo);
                cmdUpdate.Parameters.AddWithValue("@telefono", telefono);
                cmdUpdate.ExecuteNonQuery();

                conex.CerrarConexion();

                MessageBox.Show("Contraseña actualizada correctamente.");
                Login login = new Login();
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}
