using System;
using System.Collections.Generic;
using System.Text;
using tp1.Strategy;

namespace tp1.clases_TP5
{
    class AlumnoProxy : IAlumno
    {
        Alumno alumno = null;

        protected int legajo;
        protected double promedio;
        protected int calificacion;
        protected StrategyCompararAlumnos _StrategyCompararAlumnos;

        public AlumnoProxy(string nombre, int dni, int legajo, double promedio)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            _StrategyCompararAlumnos = new StrategyComparacionNombre();
        }

        public override int getLegajo()
        {
            if (this.alumno == null)
            {
                return this.legajo;
            }
            else
            {
                return this.alumno.getLegajo();
            }
        }
        public override double getPromedio()
        {
            if (this.alumno == null)
            {
                return this.promedio;
            }
            else
            {
                return this.alumno.getPromedio();
            }
           
        }
        public override int getCalificacion()
        {
            if (this.alumno == null)
            {
                return this.calificacion;
            }
            else
            {
                return this.alumno.getCalificacion();
            }
        }
        public override void setCalificacion(int calificacion)
        {
            if (this.alumno == null)
            {
                this.calificacion = calificacion;
            }
            else
            {
                this.alumno.setCalificacion(calificacion);
            }
        }
            
        public override void setComparacion(StrategyCompararAlumnos comparacion)
        {
            this._StrategyCompararAlumnos = comparacion;
        }

        public override int responderPregunta(int pregunta)
        {
            if (alumno == null)
            {
                alumno = new Alumno(nombre, dni, legajo, promedio);
                alumno.setComparacion(_StrategyCompararAlumnos);
            }
            return this.alumno.responderPregunta(pregunta);
        }
        public override string mostrarUltimaCalificacion()
        {
            if (this.alumno == null)
            {
                return this.getNombre() + "    " + getCalificacion().ToString();
            }
            else
            {
                this.alumno.mostrarUltimaCalificacion();
            }
            return this.getNombre() + "    " + getCalificacion().ToString();
        }
    }
}
