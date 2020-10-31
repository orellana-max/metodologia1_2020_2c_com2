using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6_Patron_Template_Method
{
    public interface Comparable
    {
        bool sosIgual(Comparable comparable);
        bool sosMenor(Comparable comparable);
        bool sosMayor(Comparable comparable);


    }
}
