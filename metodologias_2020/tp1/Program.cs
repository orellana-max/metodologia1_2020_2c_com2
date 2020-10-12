using System;
using System.Collections.Generic;
using tp1.ejerciciosTP1;
using tp1.clases_TP2;
using tp1.clases_TP3;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            menuTP4_04.run();
            string op;
            do {
                Console.WriteLine("Elija opcion: \n" +
                    "1 - TP1 - Ejercicio 7. \n" +
                    "2 - TP1 - Ejercicio 9. \n" +
                    "3 - TP1 - Ejercicio 13. \n" +
                    "4 - TP1 - Ejercicio 17. \n\n" +
                    "5 - TP2 - Ejercicio 8. \n" +
                    "6 - TP2 - Ejercicio 10 \n\n" +
                    "7 - TP3 - Ejercicio 6 \n" +
                    "8 - TP3 - Ejercicio 7 \n" +
                    "9 - TP3 - Ejercicio 14 \n" +
                    "9b - TP3 - Ejercicio opcional vendedor pauperrimo \n\n"+
                    "10 - TP4 - Ejercicio 04 \n" +
                    //"11 - TP4 - Ejercicio 08 \n" +
                    "Enter para salir"
                    );
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        menuTP1_07.run();
                        break;
                    case "2":
                        menuTP1_09.run();
                        break;
                    case "3":
                        menuTP1_13.run();
                        break;
                    case "4":
                        menuTP1_17.run();
                        break;
                    case "5":
                        menuTP2_08.run();
                        break;
                    case "6":
                        menuTP2_10.run();
                        break;
                    case "7":
                        menuTP3_06.run();
                        break;
                    case "8":
                        menuTP3_07.run();
                        break;
                    case "9":
                        menuTP3_14.run();
                        break;
                    case "9b":
                        menuTP3_pauperrimo.run();
                        break;
                    case "10":
                        menuTP4_04.run();
                        break;
                    //case "11":
                    //    menuTP4_08.run();
                    //    break;
                    case "":
                        Console.WriteLine("Esta saliendo.");
                        break;
                    default:
                        Console.WriteLine("No ingreso opcion valida.");
                        break;
                }
                Console.WriteLine("\n \t Presione una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (op != "");
           
        }
        public static string randomNombres()
        {
            List<string> nombres = new List<string>() { "Maximiliano", "Aaron", "Valeria", "Martina", "Daniel",
                "Claudia", "Marcela", "Julio", "Leon", "Laureano", "Blanca", "Sandra", "Walter", "Exequiel",
                "Fabiana", "Ivan", "Benjamin", "Tristan","Nestor", "Cristina", "Alberto", "Juan", "Jose", "Daya", "Daiana",
                "Belen", "Evelyn", "Karina", "Natalia", "Gabriel", "Daniela", "Javier", "Cristian", "Nuny", "Veronica",
                "Miguel", "Lorena", "Milagros", "Roberto", "Franco", "Isabela", "Maria", "Gladiz", "Miriam",
                "Ivana", "Vanina", "Tini","Matias", "Gisela", "Estela", "Susana","Abel", "Norma", "Mariela", "Alan",
                "Tito", "Campi", "Noelia","Melina","Mabel","julino","Agustina","Cintia","Tamara", "Papu","Martin",
                "Hugo","Roman","Rodrigo","Leonardo","Gabriela","Ernesto","Elba","Capi","Rulo","Mia","Chino","Bichito",
                "Nina","Antonio","Renzo","Loly","Barry","Laurel","Joel","Federico","Silvio","Mario","Claudio",
                "Josue","Tadeo","Mateo","Judas","Antifaz","Mateo", "Angel","Ricardo","Diego","Angela","Karim"};

            return nombres[new Random().Next(nombres.Count)];
        }
    }
}
