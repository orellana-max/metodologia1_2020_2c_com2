using System;
using System.Collections.Generic;
using System.Text;
using tp1.Strategy;

namespace tp1.ejerciciosTP1
{
    class menuTP1_17
    {

        public static void run()
        {
            Console.WriteLine("Ejercicio 17: ");
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            Program.llenar(pila, 2);
            Program.llenar(cola, 2);
            //llenarAlumnos(pila);
            //llenarAlumnos(cola);

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
