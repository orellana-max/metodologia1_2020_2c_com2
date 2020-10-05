using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP2
{
    class ClaveValor: Comparable
    {
        Comparable clave;
        Comparable valor;

        public ClaveValor(Comparable c, Comparable valor)
        {
            this.clave = c;
            this.valor = valor;
        }

        public Comparable getClave()
        {
            return this.clave;
        }
        public Comparable getValor()
        {
            return this.valor;
        }
        public void setValor(Comparable valor)
        {
            this.valor = valor;
        }

        public bool sosIgual(Comparable comparable)
        {
            return this.valor.sosIgual(((ClaveValor)comparable).getValor());
        }

        public bool sosMayor(Comparable comparable)
        {
            return this.valor.sosMayor(((ClaveValor)comparable).getValor());
        }

        public bool sosMenor(Comparable comparable)
        {
            return this.valor.sosMenor(((ClaveValor)comparable).getValor());
        }

        public override string ToString()
        {
            return String.Format(this.getValor().ToString() + " Clave:" + this.getClave().ToString());
        }
    }
}
