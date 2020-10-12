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
            //int idx = elementoDecorado.mostrarUltimaCalificacion().IndexOf(this.getNombre());
            //string cali = elementoDecorado.mostrarUltimaCalificacion().Insert(idx, orden.ToString() + ") ");
            //orden++;
            //return cali;
            return String.Format("{0}) {1}", orden, elementoDecorado.mostrarUltimaCalificacion());
        }
    }
}
