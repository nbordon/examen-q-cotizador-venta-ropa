using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Prenda
    {
        #region Atributos
        private CalidadPrenda calidad;
        private double precioUnitario;
        private int stock;
        #endregion

        #region Constructores
        public Prenda(CalidadPrenda calidad, double precio, int stock)
        {
            this.calidad = calidad;
            this.precioUnitario = precio;
            this.stock = stock;
        }
        #endregion

        #region Propiedades
        public CalidadPrenda Calidad => calidad;
        public virtual double Precio => precioUnitario;
        public int Stock => stock;
        #endregion

        #region Métodos
        protected double MultiplicadorPorCalidad()
        {
            var multiplicador = 1.0;

            if (this.Calidad == CalidadPrenda.PREMIUM)
                multiplicador = 1.3;

            return multiplicador;
        }
        #endregion
    }

    public enum CalidadPrenda
    {
        STANDARD,
        PREMIUM
    }
}