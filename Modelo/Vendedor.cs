using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vendedor
    {
        #region Atributos
        private int codigo;
        private string nombre;
        private string apellido;
        private List<Cotizacion> historialCotizaciones;
        #endregion

        #region Constructores
        public Vendedor(int codigo, string nombre, string apellido)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.historialCotizaciones = new List<Cotizacion>();
        }
        #endregion

        #region Propiedades
        public int Codigo => codigo;
        public string Nombre => nombre;
        public string Apellido => apellido;
        public List<Cotizacion> HistorialCotizaciones => historialCotizaciones;
        #endregion

        #region Métodos
        public void AgregarCotizacion(Cotizacion cotizacion)
        {
            historialCotizaciones.Add(cotizacion);
        }

        public int ProximoId()
        {
            if (historialCotizaciones.Count == 0)
                return 1;
            else
                return 2;
        }
        #endregion
    }
}