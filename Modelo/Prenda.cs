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
        public double Precio => precioUnitario;
        public int Stock => stock;
        #endregion
    }

    public enum CalidadPrenda
    {
        STANDARD,
        PREMIUM
    }
}