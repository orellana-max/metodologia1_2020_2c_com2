using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Strategy
{
    interface StrategyCompararAlumnos
    {
        bool sosIgual(Alumno comparable1, Alumno comparable2);
        bool sosMayor(Alumno comparable1, Alumno comparable2);
        bool sosMenor(Alumno comparable1, Alumno comparable2);
    }
}
