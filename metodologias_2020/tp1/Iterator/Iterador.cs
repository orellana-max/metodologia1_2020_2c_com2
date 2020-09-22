using System;
using System.Collections.Generic;
using System.Text;
using tp1;

namespace tp1.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}
