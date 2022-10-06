using ModeloDominio;
using ModeloNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionConsola
{
    public class Consola
    {
        private Conversor con;
        
        public Consola(Conversor c)
        {
            this.con = c;
        }

        public void mostrarMenu()
        {
            String divOriginal, divACambiar;
            Divisa d1, d2;
            double cant;

            Console.WriteLine("Introduce divisa original:");
            divOriginal = Console.ReadLine();
            Console.WriteLine("Introduce divisa a cambiar:");
            divACambiar = Console.ReadLine();
            Console.WriteLine("Cantidad a convertir:");
            cant = Console.Read();
            Console.WriteLine("El resultado es:");
            d1 = new Divisa(divOriginal, )
        }
    }
}
