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
            InicializarVista();
            cotizadorController = new CotizadorController(this);
        }

        #region IVIEW
        public int Cantidad()
        {
            try
            {
                txtCantidad.BackColor = Color.White;
                return Convert.ToInt32(txtCantidad.Text);
            }
            catch(Exception e)
            {
                txtCantidad.BackColor = Color.Orange;
                MessageBox.Show(this,"Cantidad no válida", "Error de Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
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
            try
            {
                txtPrecioUnitario.BackColor = Color.White;
                return Convert.ToDouble(txtPrecioUnitario.Text);
            }
            catch (Exception e)
            {
                txtPrecioUnitario.BackColor = Color.Orange;
                MessageBox.Show(this,"Precio Unitario no valido","Error de Precio",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }
        }

        public void MostrarCantidadStock(string cantidad)
        {
            txtStock.Text = cantidad;
        }
        #endregion

        #region Validaciones
        private void radCamisa_CheckedChanged(object sender, EventArgs e)
        {
            chkChupin.Enabled = !radCamisa.Checked;
            if(cotizadorController!=null)cotizadorController.RecalcularStock();
        }

        private void radPantalon_CheckedChanged(object sender, EventArgs e)
        {
            chkCuelloMao.Enabled = !radPantalon.Checked;
            chkMarngaCorta.Enabled = !radPantalon.Checked;
            if (cotizadorController != null) cotizadorController.RecalcularStock();
        }
        private void chkMarngaCorta_CheckedChanged(object sender, EventArgs e)
        {
            if (cotizadorController != null) cotizadorController.RecalcularStock();
        }

        private void chkCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            if (cotizadorController != null) cotizadorController.RecalcularStock();
        }

        private void chkChupin_CheckedChanged(object sender, EventArgs e)
        {
            if (cotizadorController != null) cotizadorController.RecalcularStock();
        }

        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (cotizadorController != null) cotizadorController.RecalcularStock();
        }

        private void radPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (cotizadorController != null) cotizadorController.RecalcularStock();
        }
        #endregion

        #region Inicializaciones
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
        #endregion

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCantidad.BackColor = Color.White;
                cotizadorController.NuevaCotizacion();
            }
            catch(Exception ex)
            {
                txtCantidad.BackColor = Color.Orange;
                MessageBox.Show(this, ex.Message, "Error al cotizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCotizacion.Text = "";
            }
        }
    }
}
