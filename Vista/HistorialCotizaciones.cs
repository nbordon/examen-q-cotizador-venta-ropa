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
    public partial class HistorialCotizaciones : Form,IViewHistorial
    {
        private HistorialController historialController;
        public HistorialCotizaciones(CotizadorController cotizador)
        {
            InitializeComponent();
            historialController = new HistorialController(this, cotizador);
            historialController.ObtenerHistorial();
        }

        #region IVIEW
        public void MostrarHistorial(List<string> historial)
        {
            lstCotizaciones.DataSource = historial;
        }
        #endregion
    }
}
