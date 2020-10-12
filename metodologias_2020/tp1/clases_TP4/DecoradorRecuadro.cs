using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    class DecoradorRecuadro : DecoradorAlumno
    {
        public DecoradorRecuadro(IDecorador elementoDecorado) : base(elementoDecorado)
        {
        }

        public override string mostrarUltimaCalificacion()
        {
            string asteriscos = new string('*', (this.elementoDecorado.mostrarUltimaCalificacion()).Length + 10);

            return asteriscos + "\n*    " + elementoDecorado.mostrarUltimaCalificacion() + "    *\n" + asteriscos;
        }
    }
}
