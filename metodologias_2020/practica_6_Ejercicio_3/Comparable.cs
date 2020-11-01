using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
{
    public interface IComparable
    {
        bool sosIgual(IComparable comparable);
        bool sosMenor(IComparable comparable);
        bool sosMayor(IComparable comparable);


    }
}
