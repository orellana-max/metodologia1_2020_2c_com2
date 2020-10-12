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
            //return elementoDecorado.mostrarUltimaCalificacion().Insert(++idx, a.getLegajo().ToString())

            //Alumno a = (Alumno)this.elementoDecorado;
            //string nombre = a.getNombre();
            //int idx = a.mostrarUltimaCalificacion().IndexOf(nombre) + nombre.Length;
            //return a.mostrarUltimaCalificacion().Insert(++idx, a.getLegajo().ToString());
        }
    }
}
