using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;

namespace tp1.clases_TP4
{
    class AdapterAlumnoCompuestoToStudent : Student
    {
        AlumnoCompuesto alumno;

        public AdapterAlumnoCompuestoToStudent(AlumnoCompuesto alumno)
        {
            this.alumno = alumno;
        }

        public bool equals(Student student)
        {
            return this.alumno.getNombre().CompareTo(student.getName()) == 0;
            //return this.alumno.sosIgual(new AdapterStudentToAlumno(student));
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return this.alumno.getNombre().CompareTo(student.getName()) > 0;
            //return this.alumno.sosMayor(new AdapterStudentToAlumno(student));
        }

        public bool lessThan(Student student)
        {
            return this.alumno.getNombre().CompareTo(student.getName()) < 0;
            //return this.alumno.sosMenor(new AdapterStudentToAlumno(student));
        }

        public void setScore(int score)
        {
            this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
            IDecorador decoracion = new DecoradorLegajo(alumno);
            decoracion = new DecoradorNotasEnLetras(decoracion);
            decoracion = new DecoradorAprobacion(decoracion);
            decoracion = new DecoradorNumeroSecuencia(decoracion);
            decoracion = new DecoradorRecuadro(decoracion);
            return decoracion.mostrarUltimaCalificacion();
            //return this.alumno.getCalificacion().ToString();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }
    }
}
