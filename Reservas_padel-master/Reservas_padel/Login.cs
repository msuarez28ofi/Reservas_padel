using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservas_padel
{
    public partial class Login : Form
    {
        public static string nombreUsuario = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btEnviarARegistro_Click(object sender, EventArgs e)
        {
            CrearCuenta crear = new CrearCuenta();
            crear.Show();
            this.Hide();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string correo = tbUsuario.Text.Trim();
            string contrasena = tbContrasena.Text.Trim();

            if (correo == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                conex.connnect();

                string consulta = "SELECT * FROM Usuario WHERE Correo_Usuario = '" + correo + "' AND Contrasena_Usuario = '" + contrasena + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, conex.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Inicio de sesión exitoso.");

                    // Guardar el nombre del usuario en la variable pública
                    nombreUsuario = reader["Nombre_Usuario"].ToString();

                    // Abrir el formulario de reservas
                    Reservas frm = new Reservas();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }

                reader.Close();
                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }
    }
}
