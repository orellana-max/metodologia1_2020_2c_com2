using System;
using System.Collections.Generic;
using System.Text;
using tp1;
using tp1.clases_TP2;

namespace tp1.Iterator
{
    // iterador concreto

    class IteradorDeDiccionario : Iterador
    {
        int indiceActual;
        List<ClaveValor> elementos;

        public IteradorDeDiccionario(List<ClaveValor> listaDeDiccionario)
        {
            this.elementos = listaDeDiccionario;
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
