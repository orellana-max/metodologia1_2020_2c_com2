using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    class DecoradorLegajo : DecoradorAlumno
    {
        public DecoradorLegajo(IDecorador elementoDecorado) : base(elementoDecorado)
        {
        }

        public override string mostrarUltimaCalificacion()
        {
            int idx = elementoDecorado.mostrarUltimaCalificacion().IndexOf(this.getNombre()) + this.getNombre().Length;
            return elementoDecorado.mostrarUltimaCalificacion().Insert(idx, " (" + this.getLegajo().ToString() +")");
        }
    }
}
