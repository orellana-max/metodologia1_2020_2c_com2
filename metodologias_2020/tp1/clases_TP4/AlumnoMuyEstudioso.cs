using System;
using System.Collections.Generic;
using System.Text;
using tp1.Strategy;

namespace tp1
{
    class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio) :
            base(nombre, dni, legajo, promedio)
        {
        }
        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
