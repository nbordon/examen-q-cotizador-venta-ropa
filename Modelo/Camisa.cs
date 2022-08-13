using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Camisa : Prenda
    {
        #region Atributos
        private bool tieneCuelloMao;
        private bool tieneMangasLargas;
        #endregion

        #region Constructores
        public Camisa(CalidadPrenda calidad, double precio, int stock, bool tieneCuelloMao,bool tieneMangasLargas) : base(calidad, precio, stock)
        {
            this.tieneCuelloMao = tieneCuelloMao;
            this.tieneMangasLargas = tieneMangasLargas;
        }
        #endregion

        #region Propiedades
        public bool TieneCuelloMao => tieneCuelloMao;
        public bool TieneMangasLargas => tieneMangasLargas;

        public override double Precio
        {
            get
            {
                var precio = base.Precio;
                
                if (!tieneMangasLargas)
                    precio *= 0.9;

                if (tieneCuelloMao)
                    precio *= 1.03;

                return precio * MultiplicadorPorCalidad();
            }
        }
        #endregion
    }
}
