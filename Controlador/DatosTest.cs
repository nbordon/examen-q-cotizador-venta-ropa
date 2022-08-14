using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class DatosTest
    {
        private static Modelo.Vendedor JUAN_PEREZ = new Modelo.Vendedor(1,"Juan", "Perez");
        private static Modelo.Tienda TIENDA_ARCOIRIS = new Modelo.Tienda("Tienda Arcoiris", "Arcos 1288, CABA");

        public static List<Modelo.Prenda> GenerarPrendas()
        {
            List<Modelo.Prenda> listaPrendas = new List<Modelo.Prenda>();

            // 1000 Camisas
                // 500 Manga Corta
                    // 200 Cuello Mao
                        // 100 Calidad Standard
                        Modelo.Camisa c1 = new Modelo.Camisa(Modelo.CalidadPrenda.STANDARD, 0, 100, true,false);
                        // 100 Calidad Premium
                        Modelo.Camisa c2 = new Modelo.Camisa(Modelo.CalidadPrenda.PREMIUM, 0, 100, true,false);
                    // 300 Cuello Comun
                        // 150 Calidad Standard
                        Modelo.Camisa c3 = new Modelo.Camisa(Modelo.CalidadPrenda.STANDARD, 0, 150, false, false);
                        // 150 Calidad Premium
                        Modelo.Camisa c4 = new Modelo.Camisa(Modelo.CalidadPrenda.PREMIUM, 0, 150, false, false);
                // 500 Manga Larga
                    // 150 Cuello Mao
                        // 75 Calidad Standard
                        Modelo.Camisa c5 = new Modelo.Camisa(Modelo.CalidadPrenda.STANDARD, 0, 75, true, true);
                        // 75 Calidad Premium
                        Modelo.Camisa c6 = new Modelo.Camisa(Modelo.CalidadPrenda.PREMIUM, 0, 75, true, true);
                    // 350 Cuello Comun
                        // 175 Calidad Standard
                        Modelo.Camisa c7 = new Modelo.Camisa(Modelo.CalidadPrenda.STANDARD, 0, 175, false, true);
                        // 175 Calidad Premium
                        Modelo.Camisa c8 = new Modelo.Camisa(Modelo.CalidadPrenda.PREMIUM, 0, 175, false, true);

            // 2000 Pantalones
                // 1500 Chupines
                    // 750 Calidad Standard
                    Modelo.Pantalon p1 = new Modelo.Pantalon(Modelo.CalidadPrenda.STANDARD, 0, 750, true);
                    // 750 Calidad Premium
                    Modelo.Pantalon p2 = new Modelo.Pantalon(Modelo.CalidadPrenda.PREMIUM, 0, 750, true);
                // 500 Comunes
                    // 250 Calidad Standard
                    Modelo.Pantalon p3 = new Modelo.Pantalon(Modelo.CalidadPrenda.STANDARD, 0, 250, false);
                    // 250 Calidad Premium
                    Modelo.Pantalon p4 = new Modelo.Pantalon(Modelo.CalidadPrenda.PREMIUM, 0, 750, false);
            
            listaPrendas.Add(c1);
            listaPrendas.Add(c2);
            listaPrendas.Add(c3);
            listaPrendas.Add(c4);
            listaPrendas.Add(c5);
            listaPrendas.Add(c6);
            listaPrendas.Add(c7);
            listaPrendas.Add(c8);
            listaPrendas.Add(p1);
            listaPrendas.Add(p2);
            listaPrendas.Add(p3);
            listaPrendas.Add(p4);

            return listaPrendas;
        }

        public static Modelo.Vendedor JuanPerez { get=>JUAN_PEREZ; }
        public static Modelo.Tienda TiendaArcoiris { get=>TIENDA_ARCOIRIS; }
    }
}
