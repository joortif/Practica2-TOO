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
using static System.Net.Mime.MediaTypeNames;

namespace Principal
{
    internal class Program
    {
        static void Main()
        {
            ColeccionDivisas divisas = new ColeccionDivisas();
            

            //string xmlString;
            //using (var client = new WebClient())
            //{
            //    xmlString = client.DownloadString("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            //}

            //var xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml(xmlString);

            //foreach (XmlNode node in xmlDoc.SelectNodes("//*/Cube/@currency"))
            //{
            //Divisa d = new Divisa(node.Attributes["currency"].Value, Convert.ToDouble(node.Attributes["rate"].Value));
            //divisas.Add(d);
            // }

            Divisa divRef = new Divisa("Euro", 1);
            Divisa libra = new Divisa("Libra esterlina", 1.14);
            Divisa dolar = new Divisa("Dolar estadounidense", 1.02);
            Divisa franco = new Divisa("Franco suizo", 1.03);
            Divisa yen = new Divisa("Yen", 0.0070);
            Divisa pesoarg = new Divisa("Peso argentino", 0.0068);


            divisas.Add(divRef);
            divisas.Add(libra);
            divisas.Add(dolar);
            divisas.Add(franco);
            divisas.Add(yen);
            divisas.Add(pesoarg);

            Conversor conv = new Conversor(divRef, divisas);
            //Consola c = new Consola(conv);

            System.Windows.Forms.Application.Run(new FormConv(conv));

        }
    }
}
