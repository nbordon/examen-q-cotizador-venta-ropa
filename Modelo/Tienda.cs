using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tienda
    {
        #region Atributos
        private string nombre;
        private string direccion;
        private List<Prenda> prendasEnStock;
        #endregion

        #region Constructores
        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.prendasEnStock = new List<Prenda>();
        }
        #endregion

        #region Propiedades
        public string Nombre => nombre;
        public string Direccion => direccion;
        public List<Prenda> PrendasEnStock => prendasEnStock;
        #endregion

        #region Métodos
        public void AgregarPrendaEnStock(Prenda prenda)
        {
            prendasEnStock.Add(prenda);
        }
        #endregion
    }
}
