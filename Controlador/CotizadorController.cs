using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllador
{
    public class CotizadorController
    {
        #region Atributos
        private Modelo.Tienda tienda;
        private Modelo.Vendedor vendedor;
        private IViewCotizador _viewCotizador;
        #endregion

        #region Construcores
        public CotizadorController(IViewCotizador viewCotizador)
        {
            _viewCotizador = viewCotizador;
        }
        #endregion

        #region Métodos
        #endregion


    }
}