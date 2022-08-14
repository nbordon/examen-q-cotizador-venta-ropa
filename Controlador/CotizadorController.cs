using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CotizadorController
    {
        #region Atributos
        private IViewCotizador _viewCotizador;
        private Modelo.Tienda tienda;
        private Modelo.Vendedor vendedor;
        #endregion

        #region Construcores
        public CotizadorController(IViewCotizador viewCotizador)
        {
            _viewCotizador = viewCotizador;
            this.tienda = new Modelo.Tienda("Tienda Pepito", "Corrientes 2320");
            this.vendedor = new Modelo.Vendedor(1,"Juan", "Rodriguez");
            MostrarDatos();
        }
        #endregion

        #region Métodos
        public void NuevaCotizacion()
        {
            var cantidad = _viewCotizador.Cantidad();
            var prenda = CrearPrenda(cantidad);

            Modelo.Cotizacion cotizacion = new Modelo.Cotizacion(vendedor.ProximoId(),vendedor, prenda, cantidad);

            vendedor.AgregarCotizacion(cotizacion);

            _viewCotizador.MostrarCotizacion(cotizacion.Cotizar().ToString());
        }

        public void MostrarDatos()
        {
            _viewCotizador.MostrarDireccion(tienda.Direccion);
            _viewCotizador.MostrarRazonSocial(tienda.Nombre);
            _viewCotizador.MostrarVendedor($"{vendedor.Nombre} {vendedor.Apellido} | {vendedor.Codigo}");
        }

        private Modelo.Prenda CrearPrenda(int cantidad)
        {
            var precio = _viewCotizador.Precio();
            var esCamisa = _viewCotizador.EsCamisa();
            var esMangaCorta = _viewCotizador.EsMangaCorta();
            var conCuelloMao = _viewCotizador.ConCuelloMao();
            var esChupin = _viewCotizador.EsChupin();

            Modelo.CalidadPrenda calidad;
            if (_viewCotizador.EsPremium())
                calidad = Modelo.CalidadPrenda.PREMIUM;
            else
                calidad = Modelo.CalidadPrenda.STANDARD;

            Modelo.Prenda prenda;
            if (esCamisa)
            {
                prenda = new Modelo.Camisa(calidad, precio, cantidad, conCuelloMao, !esMangaCorta);
            }
            else
            {
                prenda = new Modelo.Pantalon(calidad, precio, cantidad, esChupin);
            }

            return prenda;
        }
        #endregion


    }
}