using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    interface FabricaDeComparables
    {
        Comparable CrearAleatorio();
        Comparable CrearPorTeclado();

        public static Comparable crearComparable(int queComparable)
        {
            FabricaDeComparables fabrica = null;

            if (queComparable == 1)
                fabrica = new FabricaDeNumeros();
            if (queComparable == 2)
                fabrica = new FabricaDeAlumnos();

            return fabrica.crearComparable();
        }
        abstract Comparable crearComparable();

    }
}
