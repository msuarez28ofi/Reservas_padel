using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservas_padel
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            string apellido = tbApellido.Text.Trim();
            string correo = tbCorreo.Text.Trim();
            string telefono = tbTelefono.Text.Trim();
            string contrasena = tbContrasena.Text.Trim();

            // Validar campos vacíos
            if (nombre == "" || apellido == "" || correo == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            try
            {
                conex.connnect();

                // Verificar si el correo ya existe
                string verificar = "SELECT COUNT(*) FROM Usuario WHERE Correo_Usuario = @correo";
                MySqlCommand cmdVerificar = new MySqlCommand(verificar, conex.conn);
                cmdVerificar.Parameters.AddWithValue("@correo", correo);

                int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El correo ya está registrado.");
                    conex.CerrarConexion();
                    return;
                }

                // Insertar nuevo usuario
                string sql = "INSERT INTO Usuario (Nombre_Usuario, Apellido_Usuario, Correo_Usuario, Telefono_Usuario, Contrasena_Usuario) " +
                             "VALUES (@nombre, @apellido, @correo, @telefono, @contrasena)";
                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.");
                conex.CerrarConexion();

                // Volver al login
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
