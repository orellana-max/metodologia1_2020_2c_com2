using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;
using tp1.Strategy;

namespace tp1
{
    class Alumno : Persona
    {
        protected int legajo;
        protected double promedio;
        protected int calificacion;
        protected StrategyCompararAlumnos _StrategyCompararAlumnos;

        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            _StrategyCompararAlumnos = new StrategyComparacionNombre();
        }

        public virtual int getLegajo()
        {
            return this.legajo;
        }
        public virtual double getPromedio()
        {
            return this.promedio;
        }
        public virtual int getCalificacion()
        {
            return this.calificacion;
        }
        public virtual void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }
        public virtual void setComparacion(StrategyCompararAlumnos comparacion)
        {
            this._StrategyCompararAlumnos = comparacion;
        }

        public virtual int responderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }
        public virtual string mostrarCalificacion()
        {
            return this.getNombre() + "\t\t" + getCalificacion().ToString();
        }


        public override bool sosIgual(Comparable comparable)
        {
            return _StrategyCompararAlumnos.sosIgual(this, (Alumno)comparable);
        }
        public override bool sosMenor(Comparable comparable)
        {
            return _StrategyCompararAlumnos.sosMenor(this, (Alumno)comparable);
        }
        public override bool sosMayor(Comparable comparable)
        {
            return _StrategyCompararAlumnos.sosMayor(this, (Alumno)comparable);
        }
        public override string ToString()
        {
            return String.Format(this.nombre + ". DNI: " + this.getDNI().ToString() +". L: "+ this.getLegajo().ToString()+". P: "+this.getPromedio().ToString());
        }
    }
}
