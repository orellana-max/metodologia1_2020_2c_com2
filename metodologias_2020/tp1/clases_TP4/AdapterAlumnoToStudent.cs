using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;

namespace tp1.clases_TP4
{
    class AdapterAlumnoToStudent : Student
    {
        Alumno alumno;

        public AdapterAlumnoToStudent(Alumno alumno)
        {
            this.alumno = alumno;
        }

        public bool equals(Student student)
        {
            return this.alumno.getNombre().CompareTo(student.getName()) == 0;
            //return this.alumno.sosIgual(student);
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            //return this.alumno.sosMayor(student);
            return this.alumno.getNombre().CompareTo(student.getName()) > 0;
        }

        public bool lessThan(Student student)
        {
            return this.alumno.getNombre().CompareTo(student.getName()) < 0;
        }

        public void setScore(int score)
        {
            this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }
    }
}
