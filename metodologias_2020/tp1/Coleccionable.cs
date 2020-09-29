using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;

namespace tp1
{
    interface Coleccionable : Iterable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable comparable);
        bool contiene(Comparable comparable);

    }
}
