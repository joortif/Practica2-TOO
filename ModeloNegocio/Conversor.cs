using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    
    public class Conversor
    {
        private Divisa divRef;
        private KeyedCollection<string, Divisa> divisas;

        public Conversor(Divisa divRef, KeyedCollection<string, Divisa> divisas)
        {
            this.divRef = divRef;
            this.divisas = divisas;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dOrig">La divisa de origen existe en la colección de divisas</param>
        /// <param name="dDest">La divisa de destino existe en la colección de divisas</param>
        /// <param name="cant"></param>
        /// <returns></returns>
        public double convertir(Divisa dOrig, Divisa dDest, double cant)
        {

        }


    }
}
