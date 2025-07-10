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
            pictureBox1 = new PictureBox();
            tbUsuario = new TextBox();
            tbContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            btIngresar = new Button();
            btEnviarARegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoPadel;
            pictureBox1.Location = new Point(132, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(150, 227);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(150, 31);
            tbUsuario.TabIndex = 1;
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(150, 309);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.PasswordChar = '*';
            tbContrasena.Size = new Size(150, 31);
            tbContrasena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(190, 199);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(180, 281);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Cotraseña";
            label2.TextAlign = ContentAlignment.TopCenter;
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
            btIngresar.Location = new Point(168, 379);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(112, 34);
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
            btEnviarARegistro.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEnviarARegistro.ForeColor = SystemColors.ButtonHighlight;
            btEnviarARegistro.Location = new Point(20, 457);
            btEnviarARegistro.Name = "btEnviarARegistro";
            btEnviarARegistro.Size = new Size(431, 33);
            btEnviarARegistro.TabIndex = 6;
            btEnviarARegistro.Text = "Soy nuevo, no tengo cuenta";
            btEnviarARegistro.UseVisualStyleBackColor = false;
            btEnviarARegistro.Click += btEnviarARegistro_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 37);
            ClientSize = new Size(456, 496);
            Controls.Add(btEnviarARegistro);
            Controls.Add(btIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Button btIngresar;
        private Button btEnviarARegistro;
    }
}
