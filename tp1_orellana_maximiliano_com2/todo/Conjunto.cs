using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;

namespace tp1.clases_TP2
{
    class Conjunto : Coleccionable
    {
        List<Comparable> elementos = new List<Comparable>();

        public bool pertenece(Comparable elemento)
        {
            return this.contiene(elemento);
        }


        public int cuantos()
        {
            return this.elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable min = null;
            if (elementos.Count > 0)
            {
                min = elementos[0];
            }

            foreach (Comparable ele in elementos)
            {
                if (min.sosMayor(ele))
                {
                    min = ele;
                }
            }
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = null;
            if (elementos.Count > 0)
                max = elementos[0];

            foreach (Comparable ele in elementos)
            {
                if (max.sosMenor(ele))
                {
                    max = ele;
                }
            }
            return max;
        }
        public void agregar(Comparable elemento)
        {
            if (!this.contiene(elemento))
            {
                elementos.Add(elemento);
            }
        }
        public bool contiene(Comparable comparable)
        {
            foreach (Comparable ele in elementos)
            {
                if (ele.sosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this.elementos);
        }
    }
}
