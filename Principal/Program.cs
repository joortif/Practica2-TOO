using ModeloDominio;
using ModeloNegocio;
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
            Divisa divRef;
            KeyedCollection<string, Divisa> divisas = new ColeccionDivisas();
        }
    }
}
