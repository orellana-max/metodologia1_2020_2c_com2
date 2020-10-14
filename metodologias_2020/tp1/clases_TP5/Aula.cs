using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP4;

namespace tp1
{
    class Aula
    {
        Teacher teacher;
        public void comenzar()
        {
            Console.WriteLine("Comienza aula");
            this.teacher = new Teacher();
        }
        public void nuevoAlumno(Alumno alumno)
        {
            this.teacher.goToClass(new AdapterAlumnoToStudent(alumno));
        }
        public void claseLista()
        {
            this.teacher.teachingAClass();
        }

    }
}
