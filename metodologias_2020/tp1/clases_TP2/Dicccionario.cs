using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace tp1.clases_TP2
{
    class Diccionario : Coleccionable
    {
        List<ClaveValor> elementos = new List<ClaveValor>();

        public void agregar(Comparable clave, Object valor)
        {
            foreach (ClaveValor v in elementos)
            {
                if (v.getClave().sosIgual(clave))
                {
                    v.setValor(valor);
                    return;
                }
            }
            ClaveValor claveValor = new ClaveValor(clave, valor);
            elementos.Add(claveValor);
        }
        public Object valorDe(Comparable clave)
        {
            foreach (ClaveValor item in elementos)
            {
                if (item.getClave().sosIgual(clave))
                {
                    return item.getValor();
                }
            }
            return null;
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
        public void agregar(Comparable comparable)
        {
            foreach (ClaveValor ele in elementos)
            {
                if (ele.sosIgual((ClaveValor)comparable))
                {
                    ele.setValor(((ClaveValor)comparable).getValor());
                }
            }
        }
        public bool contiene(Comparable comparable)
        {
            foreach (ClaveValor ele in elementos)
            {
                if (ele.sosIgual((ClaveValor)comparable))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

