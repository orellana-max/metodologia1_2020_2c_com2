using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;
using tp1.Strategy;
using tp1.clases_TP2;
using System.Runtime.CompilerServices;

namespace tp1.clases_TP3
{
    class menuTP3_07
    {
        public static void run()
        {
            Console.WriteLine("ADAPTACION MAIN PARA CREAR DISTINTOS COLECCIONABLES" +
                "\n Elija opcion 1 para crear una Pila" +
                "\n Elija opcion 2 para crear una Cola" +
                "\n Elija opcion 3 para crear un Conjunto" +
                "\n Elija opcion 4 para crear un Diccionario");
            string op = Console.ReadLine();
            Coleccionable coleccionable = FabricaDeColeccionables.crearColeccionable(op);

            Console.WriteLine("ADAPTACION MAIN TP1 Ejercicio 9 y 17" +
                "\n Elija opcion 1 para llenar con NUMEROS" +
                "\n Elija opcion 2 para llenar con ALUMNOS" +
                "\n Elija opcion 3 para llenar con VENDEDORES");
            string op2 = Console.ReadLine();

            if (op2 == "1") Console.WriteLine("Con NUMEROS");
            if (op2 == "2") Console.WriteLine("Con ALUMNOS");
            if (op2 == "3") Console.WriteLine("Con VENDEDORES");

            llenar(coleccionable, op2);
            informar(coleccionable, op2);


            static void llenar(Coleccionable coleccion, string opcion)
            {
                for (int i = 0; i < 20; i++)
                {
                    Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                    coleccion.agregar(comparable);
                }
            }
            static void informar(Coleccionable coleccion, string opcion)
            {
                Console.WriteLine("En la coleccion hay {0} elementos", coleccion.cuantos());
                Console.WriteLine("El elemento minimo de la coleccion es: {0}", coleccion.minimo());
                Console.WriteLine("El elemento maximo de la coleccion es: {0}", coleccion.maximo());

                Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
                Console.WriteLine("¿El elemento creado esta en la coleccion?");
                if (coleccion.contiene(comparable))
                {
                    Console.WriteLine("El elemento leído está en la colección.");
                }
                else
                {
                    Console.WriteLine("El elemento leído no está en la colección.");
                }
            }
        }
    }
}
