using System;
using System.Collections.Generic;
using System.Text;
using tp1;

namespace tp1.Iterator
{
    // iterador concreto

    class IteradorDeCola : Iterador
    {
        int indiceActual;
        List<Comparable> elementos;

        public IteradorDeCola(List<Comparable> listaDeCola)
        {
            this.elementos = listaDeCola;
            this.primero();
        }

        public Comparable actual()
        {
           return this.elementos[this.indiceActual];
        }

        public bool fin()
        {
            return this.indiceActual > this.elementos.Count;
        }

        public void primero()
        {
            this.indiceActual = 0;
        }

        public void siguiente()
        {
            this.indiceActual++;
        }
    }
}
