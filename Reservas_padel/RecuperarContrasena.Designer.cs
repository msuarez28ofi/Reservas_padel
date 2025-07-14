namespace Reservas_padel
{
    partial class RecuperarContrasena
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
            tbCorreo = new TextBox();
            tbCodigo = new TextBox();
            tbTelefono = new TextBox();
            tbNuevaContrasena = new TextBox();
            btModificar = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_07_14_at_12_29_32_AM;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = Color.FromArgb(30, 32, 37);
            tbCorreo.BorderStyle = BorderStyle.None;
            tbCorreo.ForeColor = SystemColors.Window;
            tbCorreo.Location = new Point(113, 112);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(158, 24);
            tbCorreo.TabIndex = 1;
            // 
            // tbCodigo
            // 
            tbCodigo.BackColor = Color.FromArgb(30, 32, 37);
            tbCodigo.BorderStyle = BorderStyle.None;
            tbCodigo.ForeColor = SystemColors.Window;
            tbCodigo.Location = new Point(113, 279);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(158, 24);
            tbCodigo.TabIndex = 2;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.FromArgb(30, 32, 37);
            tbTelefono.BorderStyle = BorderStyle.None;
            tbTelefono.ForeColor = SystemColors.Window;
            tbTelefono.Location = new Point(113, 194);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(158, 24);
            tbTelefono.TabIndex = 3;
            // 
            // tbNuevaContrasena
            // 
            tbNuevaContrasena.BackColor = Color.FromArgb(30, 32, 37);
            tbNuevaContrasena.BorderStyle = BorderStyle.None;
            tbNuevaContrasena.ForeColor = SystemColors.Window;
            tbNuevaContrasena.Location = new Point(113, 357);
            tbNuevaContrasena.Name = "tbNuevaContrasena";
            tbNuevaContrasena.Size = new Size(158, 24);
            tbNuevaContrasena.TabIndex = 4;
            // 
            // btModificar
            // 
            btModificar.BackColor = Color.FromArgb(30, 32, 37);
            btModificar.FlatAppearance.BorderSize = 0;
            btModificar.FlatStyle = FlatStyle.Flat;
            btModificar.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            btModificar.ForeColor = Color.White;
            btModificar.Location = new Point(183, 409);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(114, 29);
            btModificar.TabIndex = 5;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = false;
            btModificar.Click += button1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(224, 255, 13);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(12, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(58, 39);
            iconButton1.TabIndex = 6;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // RecuperarContrasena
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 37);
            ClientSize = new Size(800, 450);
            Controls.Add(iconButton1);
            Controls.Add(btModificar);
            Controls.Add(tbNuevaContrasena);
            Controls.Add(tbTelefono);
            Controls.Add(tbCodigo);
            Controls.Add(tbCorreo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecuperarContrasena";
            Text = "RecuperarContrasena";
            Load += RecuperarContrasena_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbCorreo;
        private TextBox tbCodigo;
        private TextBox tbTelefono;
        private TextBox tbNuevaContrasena;
        private Button btModificar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}