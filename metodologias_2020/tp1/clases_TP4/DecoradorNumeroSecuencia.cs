using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    class DecoradorNumeroSecuencia : DecoradorAlumno
    {
        public static int orden = 0;

        public DecoradorNumeroSecuencia(IDecorador elementoDecorado) : base(elementoDecorado)
        {
            orden++;
        }

        public override string mostrarUltimaCalificacion()
        {
            return String.Format("{0}) {1}", orden, elementoDecorado.mostrarUltimaCalificacion());
        }
    }
}
