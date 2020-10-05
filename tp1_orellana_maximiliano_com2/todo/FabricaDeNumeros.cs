using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            return new Numero(GeneradorDeDatosAleatorios.numeroAleatorio(999999));
        }
        public override Comparable CrearPorTeclado()
        {
            return new Numero(LectorDeDatos.numeroPorTeclado());
        }
    }
}
