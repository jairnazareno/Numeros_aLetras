using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    class NumeroALetras
    {
      static  String[] Unidades = { "cero","uno","dos","tres","cuatro","cinco",
                             "seis","siete","ocho","nueve","diez","once","doce","trece"
                              ,"catorce","quince","dieciseis","diecisiete","dieciocho","diecinueve"};

       static String[] Decenas = { "cero","diez", "veinte", "treinta", "cuarenta", 
                    "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

       static String[] Centenas = {"cero","cien","dosciento","trescientos","cuatroscientos","quinientos"
                             ,"siescientos","setecientos","ochocientos","novecientos"};
    
        public static void testUnidades()
        {
            foreach (string cad in Unidades)
            {
                Console.WriteLine(cad);
            }
        }
        /// <summary>
        /// Devielve el equivalente en letras y Unidades
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static String getUnidades(int num)
        {
            String aux = "";

            if (num >= 0 && num < 20)
                aux = Unidades[num];

            return aux;
        }
        public static String getDecenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
                aux = Unidades[num];
            else if (num >= 20 && num < 100)
            {
                int residuo = num % 10;
                aux = Decenas[num / 10];
                if (residuo > 0)
                {
                    aux +=  " y " + getUnidades(residuo);
                }
        
            }
            return aux;
        }
            public static string getCentenas(int num)
            {
                String aux = "";
                if (num >= 0 && num < 20)
                    aux = getUnidades(num);
                else if (num >= 20 && num < 100)
                {
                    int residuo = num % 10;
                    aux = Decenas[num / 10];
                    if (residuo > 0)
                        aux += " y " + getUnidades(residuo);
                }
                else if (num == 100)
                    aux = "cien";
                else if (num >= 101 && num < 1000)
                {
                    int residuo = num % 100;
                    aux = Centenas[num / 100];
                    if (residuo > 10) aux += " " + getDecenas(residuo);
                    else aux += " " + getUnidades(residuo);
                }
                return aux;
            }
        }

           
        

    }


