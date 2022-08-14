using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class HistorialController
    {
        #region Atributos
        private List<string> _historial;
        private IViewHistorial _viewHistorial;
        private CotizadorController _cotizador;
        #endregion

        #region Constructores
        public HistorialController(IViewHistorial viewHistorial, CotizadorController cotizador)
        {
            _viewHistorial = viewHistorial;
            _cotizador = cotizador;
            _historial = new List<string>();
        }
        #endregion

        #region Métodos
        public void ObtenerHistorial()
        {
            _historial.Clear();

            foreach(Modelo.Cotizacion item in _cotizador.Vendedor.HistorialCotizaciones)
            {
                Modelo.Prenda p = item.Prenda;
                string cotizacion = String.Empty;

                cotizacion = $"{item.FechaHora.ToShortTimeString()} - Vendedor: {item.Vendedor.Apellido} {item.Vendedor.Nombre} " +
                    $"Cotizacion - {item.Id}: Prenda {item.Prenda.GetType().Name} " +
                    $"- Calidad: {item.Prenda.Calidad} ";
                if (p.GetType() == typeof(Modelo.Camisa))
                {
                    Modelo.Camisa c = (Modelo.Camisa)p;
                    cotizacion += $"- Con Cuello Mao: {(c.TieneCuelloMao ? "Si" : "No")} " +
                        $"- Con Manga Larga: {(c.TieneMangasLargas ? "Si" : "No")} ";
                }

                if (p.GetType() == typeof(Modelo.Pantalon))
                {
                    Modelo.Pantalon pan = (Modelo.Pantalon)p;
                    cotizacion += $"- Es Chupin: {(pan.EsChupin ? "Si" : "No")} ";
                }
                cotizacion += $"- Cantidad: {item.Cantidad} - Precio: ${item.Cotizar().ToString("0.00")} ";

                _historial.Add(cotizacion);
            }

            _viewHistorial.MostrarHistorial(_historial);
        }
        #endregion
    }
}
