using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.ejerciciosTP1
{
    class menu13
    {

        public static void run()
        {
            Console.WriteLine("Ejercicio 13: ");
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            llenarPersonas(pila);
            llenarPersonas(cola);

            pila.listar();
            cola.listar();

            informar(multiple);
        }

        static void informar(Coleccionable coleccion)
        {
            Console.WriteLine("En la coleccion hay {0} elementos", coleccion.cuantos());
            Console.WriteLine("El elemento minimo de la coleccion es: {0}", coleccion.minimo());
            Console.WriteLine("El elemento maximo de la coleccion es: {0}", coleccion.maximo());


            Console.Write("Ingrese un valor: ");
            int num = int.Parse(Console.ReadLine());
            Comparable per = new Persona("n", num);

            if (coleccion.contiene(per))
            {
                Console.WriteLine("La persona con DNI {0} leído está en la colección.", num);
            }
            else
            {
                Console.WriteLine("La persona con DNI {0} leído no está en la colección.", num);
            }
        }

        static void llenarPersonas(Coleccionable coleccion)
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Comparable p = new Persona(Program.randomNombres(), r.Next(0, 50));
                coleccion.agregar(p);
            }
        }
    }
}
