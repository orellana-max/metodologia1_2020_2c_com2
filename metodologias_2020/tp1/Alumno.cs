using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;
using tp1.clases_TP4;
using tp1.Strategy;

namespace tp1
{
    class Alumno : IAlumno
    {
        protected int legajo;
        protected double promedio;
        protected int calificacion;
        protected StrategyCompararAlumnos _StrategyCompararAlumnos;
        // adicional para decoracion
        //protected DecoradorAlumno decorador;

        public Alumno(string nombre, int dni, int legajo, double promedio)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            _StrategyCompararAlumnos = new StrategyComparacionNombre();
            Console.WriteLine("Se creo un Alumno concreto");
        }

        public override int getLegajo()
        {
            return this.legajo;
        }
        public override double getPromedio()
        {
            return this.promedio;
        }
        public override int getCalificacion()
        {
            return this.calificacion;
        }
        public override void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }
        public override void setComparacion(StrategyCompararAlumnos comparacion)
        {
            this._StrategyCompararAlumnos = comparacion;
        }

        public override int responderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }
        public override string mostrarUltimaCalificacion()
        {
            return this.getNombre() + "    " + getCalificacion().ToString();
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
