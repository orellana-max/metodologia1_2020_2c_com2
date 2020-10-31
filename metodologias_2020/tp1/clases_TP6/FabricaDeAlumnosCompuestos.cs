using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP5;
using tp1.clases_TP3;

namespace tp1
{
    class FabricaDeAlumnosCompuestos : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            return new AlumnoCompuesto();
        }
        public override Comparable CrearPorTeclado()
        {
            return new AlumnoCompuesto();
        }
    }
}
