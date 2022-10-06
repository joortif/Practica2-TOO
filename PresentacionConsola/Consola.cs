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
            String divisa1, divisa2;
            Divisa divOrig, divACambiar;
            double cant;

            Console.WriteLine("Introduce divisa original: ");
            divisa1 = Console.Read().ToString();
            while (!con.Divisas.Contains(divisa1)){
                Console.WriteLine("Divisa no registrada. Introduzca otra divisa: ");
                divisa1 = Console.ReadLine();
            }

            Console.WriteLine("Introduce divisa a cambiar:");
            divisa2 = Console.Read().ToString();
            while (!con.Divisas.Contains(divisa2)){
                Console.WriteLine("Divisa no registrada. Introduzca otra divisa: ");
                divisa2 = Console.ReadLine();
            }

            Console.WriteLine("Cantidad a convertir:");
            cant = Console.Read();
            while (cant < 0)
            {
                Console.WriteLine("Cantidad no válida. Introduzca otra cantidad a convertir: ");
                cant = Console.Read();
            }

            divOrig = con.Divisas[divisa1];
            divACambiar = con.Divisas[divisa2];

            Console.WriteLine("El resultado es:" + con.convertir(divOrig, divACambiar, cant));
            
        }
    }
}
