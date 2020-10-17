using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    public abstract class FabricaDeComparables
    {
        public abstract Comparable CrearAleatorio();
        public abstract Comparable CrearPorTeclado();

        /// <summary>
        /// opcion 1 devuelve un Número.
        /// opcion 2 devuelve un Alumno.
        /// opcion 2.1 devuelve un AlumnoMuyEstudioso.
        /// opcion 2.2 devuelve un AlumnoProxy.
        /// opcion 2.3 devuelve un AlumnoMuyEstudiosoProxy.
        /// opcion 3 devuelve un Vendedor.
        /// opcion 4 devuelve un VendedorPauperrimo.
        /// </summary>
        /// <param name="opcion"></param>
        /// <returns></returns>
        public static Comparable crearAleatorio(string opcion)
        {
            FabricaDeComparables fabrica = null;

            if (opcion == "1")
                fabrica = new FabricaDeNumeros();
            if (opcion == "2")
                fabrica = new FabricaDeAlumnos();
            if (opcion == "2.1")
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
            if (opcion == "2.2")
                fabrica = new FabricaDeAlumnosProxy();
            if (opcion == "2.3")
                fabrica = new FabricaDeAlumnosMuyEstudiosoProxy();
            if (opcion == "3")
                fabrica = new FabricaDeVendedores();
            if (opcion == "4")
                fabrica = new FabricaDeVendedoresPauperrimo();

            return fabrica.CrearAleatorio();
        }

        public static Comparable crearPorTeclado(string opcion)
        {
            FabricaDeComparables fabrica = null;

            if (opcion == "1")
                fabrica = new FabricaDeNumeros();
            if (opcion == "2")
                fabrica = new FabricaDeAlumnos();
            if (opcion == "2.1")
                fabrica = new FabricaDeAlumnosMuyEstudiosos();
            if (opcion == "2.2")
                fabrica = new FabricaDeAlumnosProxy();
            if (opcion == "2.3")
                fabrica = new FabricaDeAlumnosMuyEstudiosoProxy();
            if (opcion == "3")
                fabrica = new FabricaDeVendedores();
            if (opcion == "4")
                fabrica = new FabricaDeVendedoresPauperrimo();

            return fabrica.CrearPorTeclado();
        }
    }
}