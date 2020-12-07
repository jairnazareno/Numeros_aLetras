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

       static String[] Decenas = { "diez", "veinte", "treinta", "cuarenta", 
                    "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

       static String[] Centenas = {"cien","dosciento","trescientos","cuatroscientos","quinientos"
                             ,"siescientos","setecientos","ochocientos","novecientos"};
    
        public static void testUnidades()
        {
            foreach (string cad in Unidades)
            {
                Console.WriteLine(cad);
            }
        }
        /// <summary>
        /// Devielve el equivalente en letras y unidades
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string getUnidades(int num)
        {
            String aux = "";

            if (num >= 0 && num < 20)
                aux = Unidades[num];

            return "";
        }
    }

}
