using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class ColeccionDivisas : KeyedCollection<string, Divisa>
    {
        private string nombre;
        private Divisa divisa;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Divisa Divisa
        {
            get { return divisa; } 
            set { divisa = value; }
        }


        protected override string GetKeyForItem(Divisa item)
        {
            return item.Nombre;
        }

        
    }
   
}
