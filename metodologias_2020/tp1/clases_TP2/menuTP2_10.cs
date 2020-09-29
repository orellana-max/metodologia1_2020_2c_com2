using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;
using tp1.Strategy;
using tp1.clases_TP2;


namespace tp1.ejerciciosTP1
{
    class menuTP2_10
    {
        public static void run()
        {
            Console.WriteLine("Ejercicio : 10");
            Pila pila = new Pila();
            llenarAlumnos(pila);
            cambiarEstrategia(pila, new StrategyComparacionNombre());
            informar(pila);
            cambiarEstrategia(pila, new StrategyComparacionLegajo());
            informar(pila);
            cambiarEstrategia(pila, new StrategyComparacionPromedio());
            informar(pila);
            cambiarEstrategia(pila, new StrategyComparacionDNI());
            informar(pila);
        }

        private static void cambiarEstrategia(Iterable iterable, StrategyCompararAlumnos strategyAlumno)
        {
            Iterador iterador = iterable.crearIterador();
            while (!iterador.fin())
            {
                ((Alumno)iterador.actual()).setComparacion(strategyAlumno);
                iterador.siguiente();
            }
        }

        static void llenarAlumnos(Coleccionable coleccion)
        {
            Random r = new Random();
            StrategyCompararAlumnos estrategiaDeComparacion = new StrategyComparacionNombre();
            for (int i = 0; i < 20; i++)
            {
                Comparable a = new Alumno(Program.randomNombres(), r.Next(0, 100), r.Next(1000, 9999), r.Next(10) / 1.0);
                ((Alumno)a).setComparacion(estrategiaDeComparacion);
                coleccion.agregar(a);
            }
        }
        static void informar(Coleccionable coleccion)
        {
            Console.WriteLine("En la coleccion hay {0} elementos", coleccion.cuantos());
            Console.WriteLine("El elemento minimo de la coleccion es: {0}", coleccion.minimo());
            Console.WriteLine("El elemento maximo de la coleccion es: {0}", coleccion.maximo());


            //Console.Write("Ingrese un valor: ");
            //int num = int.Parse(Console.ReadLine());
            //Comparable alm = new Alumno("n", num, 1000, 7.5);

            //if (coleccion.contiene(alm))
            //{
            //    Console.WriteLine("El alumno con DNI {0} leído está en la colección.", num);
            //}
            //else
            //{
            //    Console.WriteLine("EL alumno con DNI {0} leído no está en la colección.", num);
            //}
        }
    }
}
