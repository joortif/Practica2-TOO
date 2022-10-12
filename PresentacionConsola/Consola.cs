﻿using ModeloDominio;
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
            double cant, res;

            //Lista de divisas
            Console.WriteLine("Lista de divisas disponibles: ");
            foreach(string s in this.con.NombreDiv)
            {
                Console.WriteLine("-" + s);
            }

            //Introducción de la divisa original
            Console.WriteLine("Introduce divisa original: ");
            divisa1 = Console.ReadLine();
            divOrig = new Divisa(divisa1, 0.0);
            while (!con.ExisteDivisa(divOrig)){
                Console.WriteLine("Divisa no registrada. Introduzca otra divisa: ");
                divisa1 = Console.ReadLine();
                divOrig = new Divisa(divisa1, 0.0);
            }

            //Introducción de la divisa a cambiar
            Console.WriteLine("Introduce divisa a cambiar:");
            divisa2 = Console.ReadLine();
            divACambiar = new Divisa(divisa2, 0.0);
            while (!con.ExisteDivisa(divACambiar)){
                Console.WriteLine("Divisa no registrada. Introduzca otra divisa: ");
                divisa2 = Console.ReadLine();
                divACambiar = new Divisa(divisa2, 0.0);
            }

            Console.WriteLine("Cantidad a convertir:");
            cant = Convert.ToDouble(Console.ReadLine());
            while (cant < 0)
            {
                Console.WriteLine("Cantidad no válida. Introduzca otra cantidad a convertir: ");
                cant = Convert.ToDouble(Console.ReadLine());
            }

            res = con.Convertir(divOrig, divACambiar, cant);

            Console.WriteLine("El resultado es:" + res);
            Console.ReadLine();
        }
    }
}
