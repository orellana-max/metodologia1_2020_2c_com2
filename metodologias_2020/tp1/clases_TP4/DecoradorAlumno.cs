using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    public abstract class DecoradorAlumno : IDecorador
    {
        public IDecorador elementoDecorado;

        protected DecoradorAlumno(IDecorador elementoDecorado)
        {
            this.elementoDecorado = elementoDecorado;
        }
        public string getNombre()
        {
            return elementoDecorado.getNombre();
        }

        public int getCalificacion()
        {
            return elementoDecorado.getCalificacion();
        } 

        public int getLegajo()
        {
            return elementoDecorado.getLegajo();
        }

        public abstract string mostrarUltimaCalificacion();
    }
}
