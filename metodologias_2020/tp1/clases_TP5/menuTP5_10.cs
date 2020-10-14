using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using tp1.clases_TP3;
using tp1.clases_TP4;
using tp1.Strategy;

namespace tp1
{
    class menuTP5_10
    {
        public static void run()
        {
            Pila pila = new Pila();
            Aula aula = new Aula();
            //pila.setOrdenInicio(new OrdenInicio(aula));
            //pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            //pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
            llenar(pila, "2");// llena con 20 Alumnos.
            llenar(pila, "2.1");// llena con AlumnoMuyEsctudiosos

        }
        static void llenar(Coleccionable coleccion, string opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                coleccion.agregar(comparable);
            }
        }
    }
}
