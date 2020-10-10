using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using tp1.clases_TP3;
using tp1.clases_TP4;

namespace tp1
{
    class menuTP4_04
    {
        public static void run()
        {
            Teacher profesor = new Teacher();
            Collection students = new ListOfStudent();
            Alumno alumno;
            AdapterAlumnoToStudent estudiante;
            for (int i = 0; i < 10; i++) //agrega 10 alumnos y 10 alumnos muy estudiosos
            {
                alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
                estudiante = new AdapterAlumnoToStudent(alumno);
                students.addStudent(estudiante);
                alumno = (Alumno)FabricaDeComparables.crearAleatorio("2.1");
                estudiante = new AdapterAlumnoToStudent(alumno);
                students.addStudent(estudiante);
            }
            //students.set
            profesor.setStudents(students);
            profesor.teachingAClass();
        }

    }
}
