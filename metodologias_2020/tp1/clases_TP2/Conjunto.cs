using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;

namespace tp1.clases_TP2
{
    class Conjunto : Coleccionable, Ordenable
    {
        List<Comparable> elementos = new List<Comparable>();
        OrdenEnAula1 _ordenInicio;
        OrdenEnAula2 _ordenLlegaAlumno;
        OrdenEnAula1 _ordenAulaLlena;

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
                if (this.elementos.Count == 0)
                {
                    this._ordenInicio.ejecutar();
                }
                this._ordenLlegaAlumno.ejecutar(elemento);
                this.elementos.Add(elemento);
                if (this.elementos.Count == 40)
                {
                    this._ordenAulaLlena.ejecutar();
                }

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
        public void setOrdenInicio(OrdenEnAula1 ordenInicio)
        {
            this._ordenInicio = ordenInicio;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenLlegaAlumno)
        {
            this._ordenLlegaAlumno = ordenLlegaAlumno;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 ordenAulaLlena)
        {
            this._ordenAulaLlena = ordenAulaLlena;
        }
    }
}
