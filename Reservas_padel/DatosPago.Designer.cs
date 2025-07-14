namespace Reservas_padel
{
    partial class DatosPago
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
            tbDNI = new TextBox();
            button1 = new Button();
            tbTelefono = new TextBox();
            tbBanco = new TextBox();
            tbReferencia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.datos_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbDNI
            // 
            tbDNI.BackColor = Color.FromArgb(30, 32, 37);
            tbDNI.BorderStyle = BorderStyle.None;
            tbDNI.ForeColor = Color.White;
            tbDNI.Location = new Point(519, 134);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(197, 24);
            tbDNI.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(505, 350);
            button1.Name = "button1";
            button1.Size = new Size(177, 37);
            button1.TabIndex = 2;
            button1.Text = "Confirmar pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.FromArgb(30, 32, 37);
            tbTelefono.BorderStyle = BorderStyle.None;
            tbTelefono.ForeColor = Color.White;
            tbTelefono.Location = new Point(604, 191);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(125, 24);
            tbTelefono.TabIndex = 3;
            // 
            // tbBanco
            // 
            tbBanco.BackColor = Color.FromArgb(30, 32, 37);
            tbBanco.BorderStyle = BorderStyle.None;
            tbBanco.ForeColor = Color.White;
            tbBanco.Location = new Point(542, 246);
            tbBanco.Name = "tbBanco";
            tbBanco.Size = new Size(187, 24);
            tbBanco.TabIndex = 4;
            // 
            // tbReferencia
            // 
            tbReferencia.BackColor = Color.FromArgb(30, 32, 37);
            tbReferencia.BorderStyle = BorderStyle.None;
            tbReferencia.ForeColor = Color.White;
            tbReferencia.Location = new Point(570, 303);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(159, 24);
            tbReferencia.TabIndex = 5;
            // 
            // DatosPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 37);
            ClientSize = new Size(800, 450);
            Controls.Add(tbReferencia);
            Controls.Add(tbBanco);
            Controls.Add(tbTelefono);
            Controls.Add(button1);
            Controls.Add(tbDNI);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatosPago";
            Text = "DatosPago";
            Load += DatosPago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbDNI;
        private Button button1;
        private TextBox tbTelefono;
        private TextBox tbBanco;
        private TextBox tbReferencia;
    }
}