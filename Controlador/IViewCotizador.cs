using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllador
{
    public interface IViewCotizador
    {
        #region Métodos
        double Precio();
        int Cantidad();
        bool EsCamisa();
        bool EsPantalon();
        bool EsMangaCorta();
        bool ConCuelloMao();
        bool EsChupin();

        void MostrarCotizacion(string cotizacion);
        #endregion
    }
}
