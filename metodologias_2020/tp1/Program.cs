using System;
using System.Collections.Generic;
using tp1.ejerciciosTP1;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija opcion: \n" +
                "1 - Ejercicio 7. \n" +
                "2 - Ejercicio 9. \n" +
                "3 - Ejercicio 13. \n" +
                "4 - Ejercicio 17."
                );
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    menu07.run();
                    break;
                case "2":
                    menu09.run();
                    break;
                case "3":
                    menu13.run();
                    break;
                case "4":
                    menu17.run();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
        public static string randomNombres()
        {
            List<string> nombres = new List<string>() { "Maximiliano", "Aaron", "Valeria", "Martina", "Daniel", 
                "Claudia", "Marcela", "Julio", "Leon", "Laureano", "Blanca", "Sandra", "Walter", "Exequiel",
                "Fabiana", "Ivan", "Benjamin", "Tristan", "Matias", "Gisela", "Estela", "Susana"};

            return nombres[new Random().Next(nombres.Count)];
        }
    }
}
