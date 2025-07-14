namespace Reservas_padel
{
    partial class MisReservas
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
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dgvMisReservas = new DataGridView();
            btEliminarReserva = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMisReservas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 63);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(30, 32, 37);
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gray;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 63);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // dgvMisReservas
            // 
            dgvMisReservas.AllowUserToAddRows = false;
            dgvMisReservas.AllowUserToDeleteRows = false;
            dgvMisReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMisReservas.BackgroundColor = Color.SeaShell;
            dgvMisReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMisReservas.Location = new Point(76, 96);
            dgvMisReservas.Name = "dgvMisReservas";
            dgvMisReservas.ReadOnly = true;
            dgvMisReservas.RowHeadersWidth = 62;
            dgvMisReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMisReservas.Size = new Size(1218, 455);
            dgvMisReservas.TabIndex = 1;
            dgvMisReservas.CellContentClick += dtwMisReservas_CellContentClick;
            // 
            // btEliminarReserva
            // 
            btEliminarReserva.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEliminarReserva.Location = new Point(530, 591);
            btEliminarReserva.Name = "btEliminarReserva";
            btEliminarReserva.Size = new Size(310, 62);
            btEliminarReserva.TabIndex = 2;
            btEliminarReserva.Text = "Eliminar reserva";
            btEliminarReserva.UseVisualStyleBackColor = true;
            btEliminarReserva.Click += btEliminarReserva_Click;
            // 
            // MisReservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 37);
            ClientSize = new Size(1376, 694);
            Controls.Add(btEliminarReserva);
            Controls.Add(dgvMisReservas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MisReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MisReservas";
            Load += MisReservas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMisReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dgvMisReservas;
        private Button btEliminarReserva;
    }
}