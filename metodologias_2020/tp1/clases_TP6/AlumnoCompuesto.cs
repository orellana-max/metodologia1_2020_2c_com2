using System;
using System.Collections.Generic;
using System.Text;
using tp1.Strategy;

namespace tp1
{
    class AlumnoCompuesto : IAlumno
    {
        List<IAlumno> _componentes;

        public AlumnoCompuesto()
        {
            _componentes = new List<IAlumno>();
        }

        public override string getNombre()
        {
            string nombre = "";
            foreach (IAlumno alumno in _componentes)
            {
                nombre += alumno.getNombre() + " - ";
            }
            return nombre;
        }
        public override int responderPregunta(int pregunta)
        {
            int[] respuestas = new int[3];
            foreach (IAlumno alumno in this._componentes)
            {
                respuestas[alumno.responderPregunta(pregunta)]++;
            }
            int idx = 0;

            for (int i = 0; i < respuestas.Length; i++)
            {
                if (respuestas[i] > respuestas[idx])
                {
                    idx = i;
                }
            }
            return idx;
        }
        public override void setCalificacion(int calificacion)
        {
            foreach (IAlumno alumno in this._componentes)
            {
                alumno.setCalificacion(calificacion);
            }
        }
        public override string mostrarUltimaCalificacion()
        {
            string calificaciones = "";
            foreach (IAlumno alumno in this._componentes)
            {
                calificaciones += alumno.mostrarUltimaCalificacion() + "\n";
            }
            return calificaciones;
        }

        public override bool sosIgual(Comparable comparable)
        {
            foreach (IAlumno alumno in _componentes)
            {
                if (alumno.sosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }
        public override bool sosMenor(Comparable comparable)
        {
            foreach (IAlumno alumno in _componentes)
            {
                if (!alumno.sosMenor(comparable))
                {
                    return false;
                }
            }
            return true;
        }
        public override bool sosMayor(Comparable comparable)
        {
            foreach (IAlumno alumno in _componentes)
            {
                if (!alumno.sosMayor(comparable))
                {
                    return false;
                }
            }
            return true;
        }

        public void add(IAlumno alumno)
        {
            this._componentes.Add(alumno);
        }

        public override int getCalificacion()
        {
            return 0;
        }
        public override int getLegajo()
        {
            return 1;
        }
        public override double getPromedio()
        {
            return 1;
        }
        public override void setComparacion(StrategyCompararAlumnos comparacion)
        {
            foreach (IAlumno alumno in _componentes)
            {
                alumno.setComparacion(comparacion);
            }
        }
    }
}
