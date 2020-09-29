using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;
using tp1.Strategy;

namespace tp1.clases_TP2
{
    class menuTP2_08
    {
        public static void run()
        {
            Console.WriteLine("Ejercicio : 08");
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();

            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            llenarAlumnos(diccionario);

            imprimirElementos(pila);
            Console.WriteLine();
            imprimirElementos(cola);
            Console.WriteLine();
            imprimirElementos(conjunto);
            Console.WriteLine();
            imprimirElementos(diccionario);

        }

        static void imprimirElementos(Iterable coleccion)
        {
            Iterador iterador = coleccion.crearIterador();
            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual());
                iterador.siguiente();
            }
        }
        static void llenarAlumnos(Coleccionable coleccion)
        {
            Random r = new Random();
            StrategyCompararAlumnos comparacion = new StrategyComparacionNombre();
            for (int i = 0; i < 20; i++)
            {
                Comparable a = new Alumno(Program.randomNombres(), r.Next(0, 100), r.Next(1000, 9999), r.Next(10) / 1.0);
                ((Alumno)a).setComparacion(comparacion);
                coleccion.agregar(a);
            }
        }
        static void informar(Coleccionable coleccion)
        {
            Console.WriteLine("En la coleccion hay {0} elementos", coleccion.cuantos());
            Console.WriteLine("El elemento minimo de la coleccion es: {0}", coleccion.minimo());
            Console.WriteLine("El elemento maximo de la coleccion es: {0}", coleccion.maximo());


            Console.Write("Ingrese un valor: ");
            int num = int.Parse(Console.ReadLine());
            Comparable alm = new Alumno("n", num, 1000, 7.5);

            if (coleccion.contiene(alm))
            {
                Console.WriteLine("El alumno con DNI {0} leído está en la colección.", num);
            }
            else
            {
                Console.WriteLine("EL alumno con DNI {0} leído no está en la colección.", num);
            }
        }

    }
}
