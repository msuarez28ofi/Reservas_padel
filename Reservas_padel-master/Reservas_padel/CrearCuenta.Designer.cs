namespace Reservas_padel
{
    partial class CrearCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            tbNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btRegistrarse = new Button();
            tbApellido = new TextBox();
            label5 = new Label();
            tbContrasena = new TextBox();
            tbCorreo = new TextBox();
            tbTelefono = new TextBox();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoPadel;
            pictureBox1.Location = new Point(164, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(181, 204);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(150, 31);
            tbNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(213, 176);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(213, 399);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 6;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(203, 326);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            // 
            // btRegistrarse
            // 
            btRegistrarse.Location = new Point(194, 565);
            btRegistrarse.Name = "btRegistrarse";
            btRegistrarse.Size = new Size(120, 36);
            btRegistrarse.TabIndex = 10;
            btRegistrarse.Text = "Registrarse";
            btRegistrarse.UseVisualStyleBackColor = true;
            btRegistrarse.Click += btRegistrarse_Click;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(181, 276);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(150, 31);
            tbApellido.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(213, 248);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 12;
            label5.Text = "Apellido";
            // 
            // tbContrasena
            // 
            tbContrasena.Location = new Point(181, 354);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(150, 31);
            tbContrasena.TabIndex = 13;
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(181, 427);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(150, 31);
            tbCorreo.TabIndex = 14;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(181, 504);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(150, 31);
            tbTelefono.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(213, 476);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 16;
            label4.Text = "Telefono";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(30, 32, 37);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(1, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 51);
            iconButton1.TabIndex = 17;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // CrearCuenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 37);
            ClientSize = new Size(529, 626);
            Controls.Add(iconButton1);
            Controls.Add(label4);
            Controls.Add(tbTelefono);
            Controls.Add(tbCorreo);
            Controls.Add(tbContrasena);
            Controls.Add(label5);
            Controls.Add(tbApellido);
            Controls.Add(btRegistrarse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearCuenta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbNombre;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button btRegistrarse;
        private TextBox tbApellido;
        private Label label5;
        private TextBox tbContrasena;
        private TextBox tbCorreo;
        private TextBox tbTelefono;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}