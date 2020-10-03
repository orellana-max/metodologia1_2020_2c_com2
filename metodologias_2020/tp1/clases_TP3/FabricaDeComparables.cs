﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    public abstract class FabricaDeComparables
    {
        public abstract Comparable CrearAleatorio();
        public abstract Comparable CrearPorTeclado();

        public static Comparable crearAleatorio(string opcion)
        {
            FabricaDeComparables fabrica = null;

            if (opcion == "1")
                fabrica = new FabricaDeNumeros();
            if (opcion == "2")
                fabrica = new FabricaDeAlumnos();

            return fabrica.CrearAleatorio();
        }
        public static Comparable crearPorTeclado(string opcion)
        {
            FabricaDeComparables fabrica = null;

            if (opcion == "1")
                fabrica = new FabricaDeNumeros();
            if (opcion == "2")
                fabrica = new FabricaDeAlumnos();

            return fabrica.CrearPorTeclado();
        }
    }
}