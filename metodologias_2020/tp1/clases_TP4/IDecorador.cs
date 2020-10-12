using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP4
{
    public interface IDecorador
    {
        public abstract string mostrarUltimaCalificacion();
        public abstract int getLegajo();
        public abstract string getNombre();
        public abstract int getCalificacion();
    }
}
