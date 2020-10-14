using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP4;

namespace tp1.clases_TP3
{
    class StudentFactory : FabricaDeAlumnos
    {
        public override Comparable CrearAleatorio()
        {
            Alumno alumno = new Alumno(
                Program.randomNombres(),
                GeneradorDeDatosAleatorios.numeroAleatorio(1000),
                GeneradorDeDatosAleatorios.numeroAleatorio(999999),
                GeneradorDeDatosAleatorios.numeroAleatorio(100) / 10.0);
            DecoradorAlumno AlumnoDecorado = new DecoradorLegajo(alumno);
            AlumnoDecorado = new DecoradorNotasEnLetras(AlumnoDecorado);
            AlumnoDecorado = new DecoradorAprobacion(AlumnoDecorado);
            AlumnoDecorado = new DecoradorNumeroSecuencia(AlumnoDecorado);
            AlumnoDecorado = new DecoradorRecuadro(AlumnoDecorado);
            return alumno;
        }
        public override Comparable CrearPorTeclado()
        {
            Console.WriteLine("ingresar Nombre, DNI, Legajo y promedio");
            Alumno alumno = new Alumno(
               LectorDeDatos.stringPorTeclado(),
               LectorDeDatos.numeroPorTeclado(),
               LectorDeDatos.numeroPorTeclado(),
               LectorDeDatos.numeroPorTeclado() / 1.0); ;
            return alumno;
        }
    }
}
