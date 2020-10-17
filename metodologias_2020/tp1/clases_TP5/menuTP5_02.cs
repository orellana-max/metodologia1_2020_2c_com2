using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using tp1.clases_TP3;
using tp1.clases_TP4;
using tp1.Strategy;

namespace tp1
{
    class menuTP5_02
    {
        public static void run()
        {
            Teacher profesor = new Teacher();
            Collection students = new ListOfStudent();
            IAlumno alumno;
            AdapterAlumnoToStudent estudiante;
            for (int i = 0; i < 10; i++) //agrega 10 alumnos y 10 alumnos muy estudiosos
            {
                alumno = (IAlumno)FabricaDeComparables.crearAleatorio("2.2");
                estudiante = new AdapterAlumnoToStudent(alumno);
                students.addStudent(estudiante);
                alumno = (IAlumno)FabricaDeComparables.crearAleatorio("2.3");
                alumno.setComparacion(new StrategyComparacionCalificacion());
                estudiante = new AdapterAlumnoToStudent(alumno);
                students.addStudent(estudiante);
            }
            //students.set
            profesor.setStudents(students);
            profesor.teachingAClass();

        }
    }
}
