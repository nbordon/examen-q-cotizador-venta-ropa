using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pantalon : Prenda
    {
        #region Atributos
        private bool esChupin;
        #endregion

        #region Constructores
        public Pantalon(CalidadPrenda calidad, double precio, int stock, bool esChupin) : base(calidad, precio, stock)
        {
            this.esChupin = esChupin;
        }
        #endregion

        #region Propiedades
        public bool EsChupin => esChupin;
        public override double Precio
        {
            get
            {
                var precio = base.Precio;

                if (esChupin)
                    precio *= 0.88;

                return precio * MultiplicadorPorCalidad();
            }
        }
        #endregion
    }
}
