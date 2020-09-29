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

        static void imprimirElementos(Coleccionable coleccion)
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
    }
}
