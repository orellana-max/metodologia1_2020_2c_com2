using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using tp1.clases_TP3;
using tp1.clases_TP4;
using tp1.Strategy;

namespace tp1
{
    class menuTP6_02
    {
        public static void run()
        {
            Teacher profesor = new Teacher();
            Collection students = new ListOfStudent();
            IAlumno alumno;

            AdapterAlumnoToStudent estudiante;

            IAlumno alumnoCompuesto = new AlumnoCompuesto();
            
            for (int i = 0; i < 5; i++) //agrega 5 alumnos proxy
            {
                alumno = (IAlumno)FabricaDeComparables.crearAleatorio("2.2"); //2.2 alumnoProxy
                ((AlumnoCompuesto)alumnoCompuesto).add(alumno);
            }

            estudiante = new AdapterAlumnoToStudent((AlumnoCompuesto)alumnoCompuesto);
            students.addStudent(estudiante);
            profesor.setStudents(students);
            profesor.teachingAClass();

        }
    }
}
