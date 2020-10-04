using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;

namespace tp1
{
    class ColeccionMultiple : Coleccionable

    {
        Pila pila = new Pila();
        Cola cola = new Cola();

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }
        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }
        public Comparable maximo()
        {
            Comparable maxPila = pila.maximo();
            Comparable maxCola = cola.maximo();
            if (maxPila.sosMayor(maxCola))
            {
                return maxPila;
            } else
            {
                return maxCola;
            }
        }

        public Comparable minimo()
        {
            Comparable minPila = pila.minimo();
            Comparable minCola = cola.minimo();
            if (minPila.sosMenor(minCola))
            {
                return minPila;
            }
            else
            {
                return minCola;
            }
        }
        public void agregar(Comparable comparable)
        {
        }
        public bool contiene(Comparable comparable)
        {
            if (pila.contiene(comparable) || cola.contiene(comparable))
            {
                return true;
            }
            return false;
        }

        Iterador Iterable.crearIterador()
        {
            throw new NotImplementedException();
        }
    }
}
