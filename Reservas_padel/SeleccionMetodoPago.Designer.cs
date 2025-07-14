namespace Reservas_padel
{
    partial class SeleccionMetodoPago
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
            lbMontoDolar = new Label();
            lbFechaReserva = new Label();
            lbMontoBs = new Label();
            btTransferencias = new Button();
            btPagoMovil = new Button();
            btTransferenciasInter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3;
            pictureBox1.Location = new Point(25, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1007, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbMontoDolar
            // 
            lbMontoDolar.AutoSize = true;
            lbMontoDolar.BackColor = Color.FromArgb(30, 32, 37);
            lbMontoDolar.FlatStyle = FlatStyle.Flat;
            lbMontoDolar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMontoDolar.ForeColor = Color.White;
            lbMontoDolar.Location = new Point(817, 79);
            lbMontoDolar.Name = "lbMontoDolar";
            lbMontoDolar.Size = new Size(61, 28);
            lbMontoDolar.TabIndex = 1;
            lbMontoDolar.Text = "0,00$";
            // 
            // lbFechaReserva
            // 
            lbFechaReserva.AutoSize = true;
            lbFechaReserva.BackColor = Color.FromArgb(30, 32, 37);
            lbFechaReserva.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechaReserva.ForeColor = Color.White;
            lbFechaReserva.Location = new Point(845, 174);
            lbFechaReserva.Name = "lbFechaReserva";
            lbFechaReserva.Size = new Size(116, 28);
            lbFechaReserva.TabIndex = 2;
            lbFechaReserva.Text = "00/00/0000";
            // 
            // lbMontoBs
            // 
            lbMontoBs.AutoSize = true;
            lbMontoBs.BackColor = Color.FromArgb(30, 32, 37);
            lbMontoBs.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMontoBs.ForeColor = Color.White;
            lbMontoBs.Location = new Point(802, 125);
            lbMontoBs.Name = "lbMontoBs";
            lbMontoBs.Size = new Size(71, 28);
            lbMontoBs.TabIndex = 3;
            lbMontoBs.Text = "0,00Bs";
            // 
            // btTransferencias
            // 
            btTransferencias.BackColor = Color.FromArgb(224, 225, 13);
            btTransferencias.FlatStyle = FlatStyle.Flat;
            btTransferencias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTransferencias.ForeColor = Color.FromArgb(30, 32, 37);
            btTransferencias.Location = new Point(641, 315);
            btTransferencias.Name = "btTransferencias";
            btTransferencias.Size = new Size(320, 41);
            btTransferencias.TabIndex = 4;
            btTransferencias.Text = "Transferencias";
            btTransferencias.TextAlign = ContentAlignment.MiddleLeft;
            btTransferencias.UseVisualStyleBackColor = false;
            btTransferencias.Click += btTransferencias_Click;
            // 
            // btPagoMovil
            // 
            btPagoMovil.BackColor = Color.FromArgb(224, 225, 15);
            btPagoMovil.FlatStyle = FlatStyle.Flat;
            btPagoMovil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPagoMovil.ForeColor = Color.FromArgb(30, 32, 37);
            btPagoMovil.Location = new Point(641, 374);
            btPagoMovil.Name = "btPagoMovil";
            btPagoMovil.Size = new Size(320, 43);
            btPagoMovil.TabIndex = 5;
            btPagoMovil.Text = "Pago Movil";
            btPagoMovil.TextAlign = ContentAlignment.MiddleLeft;
            btPagoMovil.UseVisualStyleBackColor = false;
            btPagoMovil.Click += btPagoMovil_Click;
            // 
            // btTransferenciasInter
            // 
            btTransferenciasInter.BackColor = Color.FromArgb(224, 225, 13);
            btTransferenciasInter.FlatStyle = FlatStyle.Flat;
            btTransferenciasInter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTransferenciasInter.ForeColor = Color.FromArgb(30, 32, 37);
            btTransferenciasInter.Location = new Point(641, 433);
            btTransferenciasInter.Name = "btTransferenciasInter";
            btTransferenciasInter.Size = new Size(320, 42);
            btTransferenciasInter.TabIndex = 6;
            btTransferenciasInter.Text = "Transferencias";
            btTransferenciasInter.TextAlign = ContentAlignment.MiddleLeft;
            btTransferenciasInter.UseVisualStyleBackColor = false;
            btTransferenciasInter.Click += btTransferenciasInter_Click;
            // 
            // SeleccionMetodoPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 589);
            Controls.Add(btTransferenciasInter);
            Controls.Add(btPagoMovil);
            Controls.Add(btTransferencias);
            Controls.Add(lbMontoBs);
            Controls.Add(lbFechaReserva);
            Controls.Add(lbMontoDolar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeleccionMetodoPago";
            Text = "SeleccionMetodoPago";
            Load += SeleccionMetodoPago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbMontoDolar;
        private Label lbFechaReserva;
        private Label lbMontoBs;
        private Button btTransferencias;
        private Button btPagoMovil;
        private Button btTransferenciasInter;
    }
}