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
            //Alumno estudiante = new AdapterStudentToAlumno(student);
            //estudiante.setComparacion(this.alumno.getComparacion());
            //return this.alumno.sosIgual(estudiante);
            return false;
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return true;
            //Alumno estudiante = new AdapterStudentToAlumno(student);
            //estudiante.setComparacion(this.alumno.getComparacion());
            //return this.alumno.sosMayor(estudiante);
        }

        public bool lessThan(Student student)
        {
            return false;
            //Alumno estudiante = new AdapterStudentToAlumno(student);
            //estudiante.setComparacion(this.alumno.getComparacion());
            //return this.alumno.sosMenor(estudiante);
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
