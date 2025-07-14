namespace Reservas_padel
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            tbUsuario = new TextBox();
            tbContrasena = new TextBox();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            btIngresar = new Button();
            btEnviarARegistro = new Button();
            btOlvidaContrasena = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(731, 496);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbUsuario
            // 
            tbUsuario.BackColor = Color.FromArgb(30, 32, 37);
            tbUsuario.BorderStyle = BorderStyle.None;
            tbUsuario.ForeColor = SystemColors.Window;
            tbUsuario.Location = new Point(437, 215);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(150, 24);
            tbUsuario.TabIndex = 1;
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = Color.FromArgb(30, 32, 37);
            tbContrasena.BorderStyle = BorderStyle.None;
            tbContrasena.ForeColor = SystemColors.Window;
            tbContrasena.Location = new Point(437, 311);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(150, 24);
            tbContrasena.TabIndex = 2;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // btIngresar
            // 
            btIngresar.FlatAppearance.BorderSize = 0;
            btIngresar.FlatStyle = FlatStyle.Flat;
            btIngresar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIngresar.ForeColor = Color.White;
            btIngresar.Location = new Point(491, 389);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(112, 38);
            btIngresar.TabIndex = 5;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            btIngresar.Click += btIngresar_Click;
            // 
            // btEnviarARegistro
            // 
            btEnviarARegistro.BackColor = Color.FromArgb(30, 32, 37);
            btEnviarARegistro.FlatAppearance.BorderColor = Color.FromArgb(30, 32, 37);
            btEnviarARegistro.FlatAppearance.BorderSize = 0;
            btEnviarARegistro.FlatStyle = FlatStyle.Flat;
            btEnviarARegistro.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEnviarARegistro.ForeColor = SystemColors.ButtonHighlight;
            btEnviarARegistro.Location = new Point(335, 463);
            btEnviarARegistro.Name = "btEnviarARegistro";
            btEnviarARegistro.Size = new Size(431, 33);
            btEnviarARegistro.TabIndex = 6;
            btEnviarARegistro.Text = "Soy nuevo, no tengo cuenta";
            btEnviarARegistro.UseVisualStyleBackColor = false;
            btEnviarARegistro.Click += btEnviarARegistro_Click;
            // 
            // btOlvidaContrasena
            // 
            btOlvidaContrasena.BackColor = Color.Silver;
            btOlvidaContrasena.FlatAppearance.BorderSize = 0;
            btOlvidaContrasena.FlatStyle = FlatStyle.Flat;
            btOlvidaContrasena.Font = new Font("Segoe UI", 6F);
            btOlvidaContrasena.Location = new Point(400, 433);
            btOlvidaContrasena.Name = "btOlvidaContrasena";
            btOlvidaContrasena.Size = new Size(293, 32);
            btOlvidaContrasena.TabIndex = 7;
            btOlvidaContrasena.Text = "Olvidaste tu contraseña?";
            btOlvidaContrasena.UseVisualStyleBackColor = false;
            btOlvidaContrasena.Click += btOlvidaContrasena_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 37);
            ClientSize = new Size(731, 496);
            Controls.Add(btOlvidaContrasena);
            Controls.Add(btEnviarARegistro);
            Controls.Add(btIngresar);
            Controls.Add(tbContrasena);
            Controls.Add(tbUsuario);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbUsuario;
        private TextBox tbContrasena;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Button btIngresar;
        private Button btEnviarARegistro;
        private Button btOlvidaContrasena;
    }
}
