using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using tp1.clases_TP3;
using tp1.clases_TP4;
using tp1.Strategy;

namespace tp1
{
    class menuTP4_04
    {
        public static void run()
        {
            pruebaDecorados();

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
                alumno.setComparacion(new StrategyComparacionCalificacion());
                estudiante = new AdapterAlumnoToStudent(alumno);
                students.addStudent(estudiante);
            }
            //students.set
            profesor.setStudents(students);
            profesor.teachingAClass();

        }

        private static void pruebaDecorados()
        {
            Alumno alumno;

            Console.WriteLine("\t Prueba de decoraciones sumadas una a una\n");
            alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
            alumno.setCalificacion(7);
            DecoradorAlumno alumnoDecorado = new DecoradorLegajo(alumno);
            Console.WriteLine(alumnoDecorado.mostrarUltimaCalificacion());

            alumnoDecorado = new DecoradorNotasEnLetras(alumnoDecorado);
            Console.WriteLine(alumnoDecorado.mostrarUltimaCalificacion());

            alumnoDecorado = new DecoradorAprobacion(alumnoDecorado);
            Console.WriteLine(alumnoDecorado.mostrarUltimaCalificacion());

            alumnoDecorado = new DecoradorNumeroSecuencia(alumnoDecorado);
            Console.WriteLine(alumnoDecorado.mostrarUltimaCalificacion());

            alumnoDecorado = new DecoradorRecuadro(alumnoDecorado);
            Console.WriteLine(alumnoDecorado.mostrarUltimaCalificacion());

            //#################################################################
            Console.WriteLine("\t Prueba de decoraciones de a una\n");
            //#################################################################

            alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
            DecoradorAlumno alumnoDecorado1 = new DecoradorLegajo(alumno);
            Console.WriteLine(alumnoDecorado1.mostrarUltimaCalificacion());

            alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
            alumno.setCalificacion(5);
            DecoradorAlumno alumnoDecorado2 = new DecoradorNotasEnLetras(alumno);
            Console.WriteLine(alumnoDecorado2.mostrarUltimaCalificacion());

            alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
            alumno.setCalificacion(7);
            DecoradorAlumno alumnoDecorado3 = new DecoradorAprobacion(alumno);
            Console.WriteLine(alumnoDecorado3.mostrarUltimaCalificacion());

            alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
            alumno.setCalificacion(1);
            DecoradorAlumno alumnoDecorado4 = new DecoradorRecuadro(alumno);
            Console.WriteLine(alumnoDecorado4.mostrarUltimaCalificacion());

            alumno = (Alumno)FabricaDeComparables.crearAleatorio("2");
            alumno.setCalificacion(6);
            DecoradorAlumno alumnoDecorado5 = new DecoradorNumeroSecuencia(alumno);
            Console.WriteLine(alumnoDecorado5.mostrarUltimaCalificacion());

            DecoradorNumeroSecuencia.orden = 0;
            Console.WriteLine("\n \t Pulse tecla para continuar \n");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
