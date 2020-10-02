using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class FabricaDeAlumnos : FabricaDeComparables
    {
        public Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios dAlea = new GeneradorDeDatosAleatorios();
            return new Alumno(Program.randomNombres(), dAlea.numeroAleatorio(1000), dAlea.numeroAleatorio(999999), dAlea.numeroAleatorio(100) / 10.0);
        }
        public Comparable CrearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado()/1.0);
        }
        public Comparable crearComparable()
        {
            return this.CrearAleatorio();
        }
    }
}
