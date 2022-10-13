using ModeloDominio;
using ModeloNegocio;
using PresentacionConsola;
using PresentacionWindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;

namespace Principal
{
    internal class Program
    {
        static void Main()
        {
            ColeccionDivisas divisas = new ColeccionDivisas();

            //--Sin conectarse al Banco Central Europeo--
            //Divisa divRef = new Divisa("Euro", 1);
            //Divisa libra = new Divisa("Libra esterlina", 1.14);
            //Divisa dolar = new Divisa("Dolar estadounidense", 1.02);
            //Divisa franco = new Divisa("Franco suizo", 1.03);
            //Divisa yen = new Divisa("Yen", 0.0070);
            //Divisa pesoarg = new Divisa("Peso argentino", 0.0068);


            //divisas.Add(divRef);
            //divisas.Add(libra);
            //divisas.Add(dolar);
            //divisas.Add(franco);
            //divisas.Add(yen);
            //divisas.Add(pesoarg);

            

            //--Conectandose al Banco Central Europeo--
            Divisa divRef = new Divisa("EUR", 1);
            divisas.Add(divRef);

            XmlDocument doc = new XmlDocument();
            doc.Load(@"http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");

            XmlNodeList nodos = doc.SelectNodes("//*[@currency]");

            if (nodos != null)
            {
                foreach (XmlNode nodo in nodos)
                {
                    var div = new Divisa(nodo.Attributes["currency"].Value, Double.Parse(nodo.Attributes["rate"].Value));
                    divisas.Add(div);
                }
            }

            Conversor conv = new Conversor(divRef, divisas);

            //--Para la versión en consola--
            //Consola c = new Consola(conv);
            //c.MostrarMenu();

            //--Para la versión en formulario (Con interfaz gráfica)--
            Application.Run(new FormConv(conv));

        }
    }
}
