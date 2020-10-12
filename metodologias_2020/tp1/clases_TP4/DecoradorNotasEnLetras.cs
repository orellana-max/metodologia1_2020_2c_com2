using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    class DecoradorNotasEnLetras : DecoradorAlumno
    {
        Dictionary<int, string> dic = new Dictionary<int, string>() { 
            { 0, "cero"},{1,"uno"},{2,"dos"},{3,"tres"},{4,"cuatro"},{5,"cinco"}
        ,{6,"seis"},{7,"siete"},{8,"ocho"},{9,"nueve"},{10,"diez"}};
        public DecoradorNotasEnLetras(IDecorador elementoDecorado) : base(elementoDecorado)
        {
        }

        public override string mostrarUltimaCalificacion()
        {
            
            return elementoDecorado.mostrarUltimaCalificacion() +"("+dic[getCalificacion()]+")";
        }
    }
}
