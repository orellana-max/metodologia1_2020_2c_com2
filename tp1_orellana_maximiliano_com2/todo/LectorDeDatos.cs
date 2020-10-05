using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class LectorDeDatos
    {
        public static int numeroPorTeclado()
        {
            int num;
            string letra;
            bool cond = false;
            do
            {
                Console.WriteLine("ingrese numero");
                letra = Console.ReadLine();
                cond = int.TryParse(letra, out num);
                if (!cond)
                {
                    Console.WriteLine("Entrada incorrecta");
                }
            } while (!cond);
            return num;
        }
        public static string stringPorTeclado()
        {
            Console.Write("Ingresar dato: ");
            string str = Console.ReadLine();
            return str;
        }
    }
}
