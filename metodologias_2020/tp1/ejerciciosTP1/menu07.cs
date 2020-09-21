using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.ejerciciosTP1
{
    class menu07
    {

        public static void run()
        {
            Console.WriteLine("Ejercicio 7: ");

            Pila pila = new Pila();
            Cola cola = new Cola();

            llenar(pila);
            llenar(cola);

            pila.listar();
            cola.listar();

            informar(pila);
            informar(cola);
        }
        static void llenar(Coleccionable coleccion)
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Numero(r.Next(100));
                coleccion.agregar(comparable);
            }
        }
        static void informar(Coleccionable coleccion)
        {
            Console.WriteLine("En la coleccion hay {0} elementos", coleccion.cuantos());
            Console.WriteLine("El elemento minimo de la coleccion es: {0}", coleccion.minimo());
            Console.WriteLine("El elemento maximo de la coleccion es: {0}", coleccion.maximo());


            Console.Write("Ingrese un valor: ");
            int num = int.Parse(Console.ReadLine());
            Comparable valor = new Numero(num);
            if (coleccion.contiene(valor))
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
