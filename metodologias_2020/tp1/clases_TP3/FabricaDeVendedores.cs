using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class FabricaDeVendedores : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            return new Vendedor
            {
                nombre = Program.randomNombres(), //nombre
                dni = GeneradorDeDatosAleatorios.numeroAleatorio(1000), //DNI
                sueldoBasico = GeneradorDeDatosAleatorios.numeroAleatorio(999999), //Sueldo basico
                bonus = GeneradorDeDatosAleatorios.numeroAleatorio(30) //bonus para probar
            };
        }


        public override Comparable CrearPorTeclado()
        {
            Console.WriteLine("ingresar por separado Nombre, DNI, Sueldo Basico");
            return new Vendedor(
               LectorDeDatos.stringPorTeclado(), //nombre
               LectorDeDatos.numeroPorTeclado(), //dni
               LectorDeDatos.numeroPorTeclado());  //sueldo basico
        }
    }
}
