using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Strategy
{
    class StrategyComparacionLegajo : StrategyCompararAlumnos
    {
        public bool sosIgual(Alumno comparable1, Alumno comparable2)
        {
            return comparable1.getLegajo().Equals(comparable2.getLegajo());
        }

        public bool sosMayor(Alumno comparable1, Alumno comparable2)
        {
            if (comparable1.getLegajo().CompareTo(comparable2.getLegajo()) == 1)
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
            if (comparable1.getLegajo().CompareTo(comparable2.getLegajo()) == -1)
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
