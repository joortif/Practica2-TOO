using ModeloDominio;
using ModeloNegocio;
using PresentacionConsola;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Program
    {
        static void Main()
        {
            Divisa divRef = new Divisa("Euro", 1);
            Divisa libra = new Divisa("Libra esterlina", 1.14);
            Divisa dolar = new Divisa("Dolar estadounidense", 1.02);
            Divisa franco = new Divisa("Franco suizo", 1.03);
            Divisa yen = new Divisa("Yen", 0.0070);
            Divisa pesoArg = new Divisa("Peso argentino", 0.0068);

            ColeccionDivisas divisas = new ColeccionDivisas();

            divisas.Add(divRef);
            divisas.Add(libra);
            divisas.Add(dolar);
            divisas.Add(franco);
            divisas.Add(yen);
            divisas.Add(pesoArg);

            Conversor conv = new Conversor(divRef, divisas);
            Consola c = new Consola(conv);

        }
    }
}
