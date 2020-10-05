using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class Numero: Comparable

    {
        private int valor;
        public Numero (int v)
        {
            this.valor = v;
        }
        public int getValor()
        {
            return valor;
        }

        public bool sosIgual(Comparable comparable)
        {
           return this.getValor().CompareTo(((Numero)comparable).getValor()) == 0;
        }

        public bool sosMayor(Comparable comparable)
        {
            return this.getValor().CompareTo(((Numero)comparable).getValor()) == 1;
        }

        public bool sosMenor(Comparable comparable)
        {
            return this.getValor().CompareTo(((Numero)comparable).getValor()) == -1;
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
