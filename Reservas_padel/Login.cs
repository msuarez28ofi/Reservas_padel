using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservas_padel
{
    public partial class Login : Form
    {
        public static string nombreUsuario = "";
        public static int idUsuario = 0;


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

                string consulta = "SELECT * FROM Usuario WHERE Correo_Usuario = @correo AND Contrasena_Usuario = @contrasena";
                MySqlCommand cmd = new MySqlCommand(consulta, conex.conn);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Inicio de sesión exitoso.");

                    nombreUsuario = reader["Nombre_Usuario"].ToString();
                    idUsuario = Convert.ToInt32(reader["id_Usuario"]);

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
