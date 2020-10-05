using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Strategy
{
    class StrategyComparacionPromedio : StrategyCompararAlumnos
    {
        public bool sosIgual(Alumno comparable1, Alumno comparable2)
        {
            return comparable1.getPromedio().Equals(comparable2.getPromedio());
        }

        public bool sosMayor(Alumno comparable1, Alumno comparable2)
        {
            if (comparable1.getPromedio().CompareTo(comparable2.getPromedio()) == 1)
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
            if (comparable1.getPromedio().CompareTo(comparable2.getPromedio()) == -1)
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
