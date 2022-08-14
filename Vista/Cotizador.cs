using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlador;

namespace Vista
{
    public partial class Cotizador : Form,IViewCotizador
    {
        private CotizadorController cotizadorController;
        public Cotizador()
        {
            InitializeComponent();
            cotizadorController = new CotizadorController(this);
            InicializarVista();
        }

        public int Cantidad()
        {
            return Convert.ToInt32(txtCantidad.Text);
        }

        public bool ConCuelloMao()
        {
            return chkCuelloMao.Checked;
        }

        public bool EsCamisa()
        {
            return radCamisa.Checked;
        }

        public bool EsChupin()
        {
            return chkChupin.Checked;
        }

        public bool EsMangaCorta()
        {
            return chkMarngaCorta.Checked;
        }

        public bool EsPantalon()
        {
            return radPantalon.Checked;
        }

        public bool EsPremium()
        {
            return radPremium.Checked;
        }

        public void MostrarCotizacion(string cotizacion)
        {
            this.txtCotizacion.Text = cotizacion;
        }

        public void MostrarDireccion(string direccion)
        {
            this.lblDireccionTienda.Text = direccion;
        }

        public void MostrarRazonSocial(string razonSocial)
        {
            this.lblNombreTienda.Text = razonSocial;
        }

        public void MostrarVendedor(string nombre)
        {
            lblNombreVendedor.Text = nombre;
        }

        public double Precio()
        {
            return Convert.ToDouble(txtPrecioUnitario.Text);
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

        private void InicializarVista()
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

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            cotizadorController.NuevaCotizacion();
        }
    }
}
