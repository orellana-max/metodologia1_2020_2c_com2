using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Strategy
{
    class StrategyComparacionCalificacion : StrategyCompararAlumnos
    {
        public bool sosIgual(Alumno comparable1, Alumno comparable2)
        {
            return comparable1.getCalificacion().Equals(comparable2.getCalificacion());
        }

        public bool sosMayor(Alumno comparable1, Alumno comparable2)
        {
            if (comparable1.getCalificacion().CompareTo(comparable2.getCalificacion()) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Alumno comparable1, Alumno comparable2)
        {
            if (comparable1.getCalificacion().CompareTo(comparable2.getCalificacion()) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
