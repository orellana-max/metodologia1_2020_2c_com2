using System;
using System.Collections.Generic;
using System.Text;
using tp1;

namespace tp1.Iterator
{
    // iterador concreto

    class IteradorDePila : Iterador
    {
        int indiceActual;
        List<Comparable> elementos;

        public IteradorDePila(List<Comparable> listaDePila)
        {
            this.elementos = listaDePila;
            this.primero();
        }

        public Comparable actual()
        {
           return this.elementos[this.indiceActual];
        }

        public bool fin()
        {
            return this.indiceActual >= this.elementos.Count;
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
