using System;
using System.Collections.Generic;
using System.Text;
using tp1.Strategy;

namespace tp1
{
    class Alumno : Persona
    {
        private int legajo;
        private double promedio;
        private StrategyCompararAlumnos _StrategyCompararAlumnos;

        public Alumno (string n, int d, int l, double p): base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            _StrategyCompararAlumnos = new StrategyComparacionNombre();
        }

        public void setComparacion(StrategyCompararAlumnos comparacion)
        {
            this._StrategyCompararAlumnos = comparacion;
        }

        public int getLegajo()
        {
            return this.legajo;
        }
        public double getPromedio()
        {
            return this.promedio;
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
