using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Strategy
{
    class StrategyComparacionNombre : StrategyCompararAlumnos
    {
        public bool sosIgual(Alumno comparable1, Alumno comparable2)
        {
            return comparable1.getNombre().Equals(comparable2.getNombre());
        }

        public bool sosMayor(Alumno comparable1, Alumno comparable2)
        {
            if (comparable1.getNombre().CompareTo(comparable2.getNombre()) == 1)
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
            if (comparable1.getNombre().CompareTo(comparable2.getNombre()) == -1)
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
