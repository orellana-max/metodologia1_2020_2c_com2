﻿using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP5;

namespace tp1.clases_TP3
{
    class FabricaDeAlumnosMuyEstudiosoProxy : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            return new AlumnoMuyEstudiosoProxy(
                Program.randomNombres(),
                GeneradorDeDatosAleatorios.numeroAleatorio(1000),
                GeneradorDeDatosAleatorios.numeroAleatorio(999999),
                GeneradorDeDatosAleatorios.numeroAleatorio(100) / 10.0);
        }
        public override Comparable CrearPorTeclado()
        {
            Console.WriteLine("ingresar Nombre, DNI, Legajo y promedio");
            return new AlumnoMuyEstudiosoProxy(
               LectorDeDatos.stringPorTeclado(), 
               LectorDeDatos.numeroPorTeclado(),
               LectorDeDatos.numeroPorTeclado(),
               LectorDeDatos.numeroPorTeclado() / 1.0);; 
        }
    }
}
