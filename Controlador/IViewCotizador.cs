using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
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
        bool EsPremium();
        void MostrarCotizacion(string cotizacion);
        void MostrarVendedor(string nombre);
        void MostrarDireccion(string direccion);
        void MostrarRazonSocial(string razonSocial);
        #endregion
    }
}
