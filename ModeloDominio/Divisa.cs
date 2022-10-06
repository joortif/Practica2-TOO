using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Divisa
    {
        private string nombre;
        private double valor;

        public string Nombre
        {
            get { return nombre; }
        }
        public double Valor
        {   
            get { return valor; }
            set { valor = value; }
        }

        public Divisa(string nombre, double valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

        
        
    }
}
