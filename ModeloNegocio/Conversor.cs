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

        public KeyedCollection<string, Divisa> Divisas
        {
            get { return divisas; }
        }

        public Divisa DivRef
        {
            get { return divRef; }
            set { divRef = value; }
        }

        public List<string> NombreDiv
        {
            get
            {
                List<string> l = new List<string>();
                foreach (Divisa d in this.divisas)
                {
                    l.Add(d.Nombre);
                }
                return l;
            }
        }
        public Conversor(Divisa divRef, KeyedCollection<string, Divisa> divisas)
        {
            this.divRef = divRef;
            this.divisas = divisas;
        }
        /// <summary>
        /// Convierte la cantidad cant de la divisa de tipo dOrig a su correspondiente según la divisa dDest.
        /// </summary>
        /// <param name="dOrig">La divisa de origen existe en la colección de divisas</param>
        /// <param name="dDest">La divisa de destino existe en la colección de divisas</param>
        /// <param name="cant"></param>
        /// <returns></returns>
        public double Convertir(Divisa dOrig, Divisa dDest, double cant)
        {
            return (cant * divisas[dDest.Nombre].Valor) / divisas[dOrig.Nombre].Valor;
        }
        /// <summary>
        /// Devuelve cierto si la Divisa d existe en la colección de divisas y falso en otro caso.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool ExisteDivisa(Divisa d)
        {
            return this.divisas.Contains(d.Nombre);  
        }

    }
}
