using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP4;
using tp1.Strategy;

namespace tp1
{
    abstract class IAlumno : Persona, IDecorador
    {
        public abstract int getLegajo();
        public abstract double getPromedio();
        public abstract int getCalificacion();
        public abstract void setCalificacion(int calificacion);
        public abstract void setComparacion(StrategyCompararAlumnos comparacion);

        public abstract int responderPregunta(int pregunta);
        public abstract string mostrarUltimaCalificacion();
    }
}
