using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class GeneradorDeDatosAleatorios
    {
        public static int numeroAleatorio(int max)
        {
            return new Random().Next(1,max);
        }
        public static string stringAleatorio(int cant)
        {
            int num;
            string str = "";
            Random r = new Random();
            for (int i = 0; i < cant; i++)
            {
                num = r.Next(97, 123);
                str += Convert.ToChar(num);
            }
            return str;
        }
    }
}
