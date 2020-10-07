using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using tp1.Strategy;

namespace tp1.clases_TP4
{
    class AdapterStudentToAlumno : Alumno
    {
        Student student;
        public AdapterStudentToAlumno(Student s):base(s.getName(), 
            new Random().Next(999999), new Random().Next(9999), (new Random().Next(1,100))/10.0)
        {
            this.student = s;
        }
        
        public override int getCalificacion()
        {
            return int.Parse(this.student.showResult());
        }
        public override void setCalificacion(int calificacion)
        {
            this.student.setScore(calificacion);
        }
        public override void setComparacion(StrategyCompararAlumnos comparacion)
        {
            this._StrategyCompararAlumnos = comparacion;
        }

        public override int responderPregunta(int pregunta)
        {
            return this.student.yourAnswerIs(pregunta);

        }
    }
}
