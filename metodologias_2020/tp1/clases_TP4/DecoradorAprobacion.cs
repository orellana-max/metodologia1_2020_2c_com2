using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    class DecoradorAprobacion : DecoradorAlumno
    {
        string estado = "APROBADO";
    
        public DecoradorAprobacion(IDecorador elementoDecorado) : base(elementoDecorado)
        {
        }

        public override string mostrarUltimaCalificacion()
        {
            if (this.getCalificacion() < 4 )
                estado = "DESAPROBADO";
            if (this.getCalificacion() >= 7)
                estado = "PROMOCIÓN";


            return elementoDecorado.mostrarUltimaCalificacion() +"("+ estado +")";
        }
    }
}
