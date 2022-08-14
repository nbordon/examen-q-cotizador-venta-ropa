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
            this.tienda = DatosTest.TiendaArcoiris;
            this.vendedor = DatosTest.JuanPerez;

            foreach (var prenda in DatosTest.GenerarPrendas())
                this.tienda.AgregarPrendaEnStock(prenda);

            MostrarDatos();
        }
        #endregion

        #region Propiedades
        public Modelo.Vendedor Vendedor => vendedor;
        #endregion

        #region Métodos
        public void NuevaCotizacion()
        {
            var cantidad = _viewCotizador.Cantidad();
            var prenda = CrearPrenda(cantidad);

            
            ValidarStock(cantidad);

            Modelo.Cotizacion cotizacion = new Modelo.Cotizacion(vendedor.ProximoId(), vendedor, prenda, cantidad);

            if (cantidad < 0 || prenda.Precio < 0)
                throw new Exception("El precio y la cantidad deben ser positivos");

            if(cotizacion.Cantidad > 0 && cotizacion.Cotizar() > 0)
            {
                vendedor.AgregarCotizacion(cotizacion);

                _viewCotizador.MostrarCotizacion(cotizacion.Cotizar().ToString("0.00"));
            }
        }

        public void MostrarDatos()
        {
            _viewCotizador.MostrarDireccion(tienda.Direccion);
            _viewCotizador.MostrarRazonSocial(tienda.Nombre);
            _viewCotizador.MostrarVendedor($"{vendedor.Nombre} {vendedor.Apellido} | {vendedor.Codigo}");
            RecalcularStock();
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

        private List<Modelo.Camisa> ObtenerCamisas(Modelo.CalidadPrenda calidad, bool esMangaCorta, bool tieneCuelloMao)
        {
            List<Modelo.Prenda> prendas = this.tienda.PrendasEnStock.FindAll(p=>p.GetType() == typeof(Modelo.Camisa));
            List<Modelo.Camisa> camisas = new List<Modelo.Camisa>();
            foreach (Modelo.Prenda prenda in prendas)
            {
                camisas.Add((Modelo.Camisa)prenda);
            }

            return camisas.FindAll(c=>c.Calidad==calidad && c.TieneMangasLargas==!esMangaCorta&&c.TieneCuelloMao==tieneCuelloMao);
        }

        private List<Modelo.Pantalon> ObtenerPantalones(Modelo.CalidadPrenda calidad, bool esChupin)
        {
            List<Modelo.Prenda> prendas = this.tienda.PrendasEnStock.FindAll(p => p.GetType() == typeof(Modelo.Pantalon));
            List<Modelo.Pantalon> pantalones = new List<Modelo.Pantalon>();
            foreach (Modelo.Prenda prenda in prendas)
            {
                pantalones.Add((Modelo.Pantalon)prenda);
            }

            return pantalones.FindAll(p=>p.Calidad==calidad&&p.EsChupin==esChupin);
        }

        public int StockTotal(bool esCamisa)
        {
            int stockTotal = 0;
            if (esCamisa)
            {
                foreach(var camisa in ObtenerCamisas(ObtenerCalidad(_viewCotizador), _viewCotizador.EsMangaCorta(), _viewCotizador.ConCuelloMao()))
                {
                    stockTotal += camisa.Stock;
                }
            }
            else
            {
                foreach (var pantalon in ObtenerPantalones(ObtenerCalidad(_viewCotizador), _viewCotizador.EsChupin()))
                {
                    stockTotal += pantalon.Stock;
                }
            }

            return stockTotal;
        }

        private Modelo.CalidadPrenda ObtenerCalidad(IViewCotizador view)
        {
            if (view.EsPremium())
                return Modelo.CalidadPrenda.PREMIUM;
            else
                return Modelo.CalidadPrenda.STANDARD;
        }

        public void RecalcularStock()
        {
            _viewCotizador.MostrarCantidadStock(StockTotal(_viewCotizador.EsCamisa()).ToString());
        }

        private void ValidarStock(int cantidad)
        {
            if (cantidad > StockTotal(_viewCotizador.EsCamisa()))
                throw new Exception("Stock insuficiente para realizar la cotizacion");
        }
        #endregion
    }
}