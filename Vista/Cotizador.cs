using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Cotizador : Form
    {
        public Cotizador()
        {
            InitializeComponent();
            InicializarVista();
        }


        public void InicializarVista()
        {
            // Radio Prenda
            radCamisa.Checked = true;
            radPantalon.Checked = false;

            //ChekcPrenda
            chkCuelloMao.Checked = false;
            chkMarngaCorta.Checked = false;
            chkChupin.Checked = false;

            // Radio Calidad
            radStandard.Checked = true;
            radPremium.Checked = false;

            // Precio y cantidad
            txtPrecioUnitario.Text = "";
            txtCantidad.Text = "0";
        }

        private void radCamisa_CheckedChanged(object sender, EventArgs e)
        {
            chkChupin.Enabled = !radCamisa.Checked;
        }

        private void radPantalon_CheckedChanged(object sender, EventArgs e)
        {
            chkCuelloMao.Enabled = !radPantalon.Checked;
            chkMarngaCorta.Enabled = !radPantalon.Checked;
        }
    }
}
