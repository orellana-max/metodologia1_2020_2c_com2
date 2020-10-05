using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Strategy
{
    class StrategyComparacionDNI : StrategyCompararAlumnos
    {
        public bool sosIgual(Alumno comparable1, Alumno comparable2)
        {
            return comparable1.getDNI().Equals(comparable2.getDNI());
        }

        public bool sosMayor(Alumno comparable1, Alumno comparable2)
        {
            if (comparable1.getDNI().CompareTo(comparable2.getDNI()) == 1)
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
            if (comparable1.getDNI().CompareTo(comparable2.getDNI()) == -1)
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
