using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP2
{
    class ClaveValor: Comparable
    {
        Comparable clave;
        object valor;

        public ClaveValor(Comparable c, object valor)
        {
            this.clave = c;
            this.valor = valor;
        }

        public Comparable getClave()
        {
            return this.clave;
        }
        public Object getValor()
        {
            return this.valor;
        }
        public void setValor(Object valor)
        {
            this.valor = valor;
        }

        public bool sosIgual(Comparable comparable)
        {
            return this.clave.sosIgual(((ClaveValor)comparable).getClave());
        }

        public bool sosMayor(Comparable comparable)
        {
            return this.clave.sosMayor(((ClaveValor)comparable).getClave());
        }

        public bool sosMenor(Comparable comparable)
        {
            throw new NotImplementedException();
        }
    }
}
