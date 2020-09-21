using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable comparable);
        bool contiene(Comparable comparable);

    }
}
