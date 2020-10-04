using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class FabricaDeVendedoresPauperrimo : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            VendedorPauperrimo v = new VendedorPauperrimo
                (   Program.randomNombres(), //nombre
                    GeneradorDeDatosAleatorios.numeroAleatorio(1000), //DNI
                    GeneradorDeDatosAleatorios.numeroAleatorio(999999) //Sueldo basico    
                );
            v.bonus = GeneradorDeDatosAleatorios.numeroAleatorio(30); //bonus para probar
            return v;
        }
        public override Comparable CrearPorTeclado()
        {
            Console.WriteLine("ingresar por separado Nombre, DNI, Sueldo Basico");
            return new VendedorPauperrimo(
               LectorDeDatos.stringPorTeclado(), //nombre
               LectorDeDatos.numeroPorTeclado(), //dni
               LectorDeDatos.numeroPorTeclado());  //sueldo basico
        }
    }
}
