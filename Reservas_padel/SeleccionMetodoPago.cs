using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservas_padel
{
    public partial class SeleccionMetodoPago : Form
    {

        string tipoCancha;
        DateTime fechaSeleccionada;
        decimal tasaCambio = 40; // valor fijo para el bolívar, podés cambiarlo

        public SeleccionMetodoPago(string tipo, DateTime fecha)
        {
            InitializeComponent();
            tipoCancha = tipo;
            fechaSeleccionada = fecha;
        }
        public SeleccionMetodoPago()
        {
            InitializeComponent();
        }

        private void btPagoMovil_Click(object sender, EventArgs e)
        {
            decimal montoUSD = (tipoCancha == "Techada") ? 20 : 10;
            DatosPago frm = new DatosPago(2, montoUSD, fechaSeleccionada);
            frm.Show();
            this.Close();
        }

        private void SeleccionMetodoPago_Load(object sender, EventArgs e)
        {
            decimal montoUSD = (tipoCancha == "Techada") ? 20 : 10;
            decimal montoBs = montoUSD * tasaCambio;

            lbMontoDolar.Text = $"Monto a pagar: {montoUSD} USD";
            lbMontoBs.Text = $"Equivalente en Bs: {montoBs} Bs";
            lbFechaReserva.Text = $"Fecha de reserva: {fechaSeleccionada.ToShortDateString()}";
        }

        private void btTransferencias_Click(object sender, EventArgs e)
        {
            decimal montoUSD = (tipoCancha == "Techada") ? 20 : 10;
            DatosPago frm = new DatosPago(1, montoUSD, fechaSeleccionada);
            frm.Show();
            this.Close();
        }

        private void btTransferenciasInter_Click(object sender, EventArgs e)
        {
            decimal montoUSD = (tipoCancha == "Techada") ? 20 : 10;
            DatosPago frm = new DatosPago(1, montoUSD, fechaSeleccionada); // 1 = ID Transferencia
            frm.Show();
            this.Close();
        }
    }
}
