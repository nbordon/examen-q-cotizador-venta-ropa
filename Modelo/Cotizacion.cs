namespace Modelo
{
    public class Cotizacion
    {
        #region Atributos
        private int id;
        private DateTime fechaHora;
        private Vendedor vendedor;
        private Prenda prenda;
        private int cantidad;
        #endregion

        #region Constructores
        public Cotizacion(int id, Vendedor vendedor, Prenda prenda, int cantidad)
        {
            this.id = id;
            this.fechaHora = DateTime.Now;
            this.vendedor = vendedor;
            this.prenda = prenda;
            this.cantidad = cantidad;
        }
        #endregion

        #region Propiedades
        public int Id => id;
        public DateTime FechaHora => fechaHora;
        public Vendedor Vendedor => vendedor;
        public Prenda Prenda => prenda;
        public int Cantidad => cantidad;
        #endregion

        #region Métodos
        public double Cotizar()
        {
            return Prenda.Precio * Cantidad;
        }
        #endregion
    }
}