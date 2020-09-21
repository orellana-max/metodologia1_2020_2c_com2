using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Iterable actual();
    }
}
