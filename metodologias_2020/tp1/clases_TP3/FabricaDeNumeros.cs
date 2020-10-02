using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class FabricaDeNumeros : FabricaDeComparables
    {
        public Comparable CrearAleatorio()
        {
            return new Numero(new GeneradorDeDatosAleatorios().numeroAleatorio(999999));
        }
        public Comparable CrearPorTeclado()
        {
            return new Numero(new LectorDeDatos().numeroPorTeclado());
        }
        public Comparable crearComparable()
        {
            return this.CrearAleatorio();
        }


    }
}
