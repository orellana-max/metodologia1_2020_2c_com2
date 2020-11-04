using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;

namespace tp1
{
	class Cola : Coleccionable, Ordenable
	{
        List<Comparable> elementos = new List<Comparable>();
        OrdenEnAula1 _ordenInicio;
        OrdenEnAula2 _ordenLlegaAlumno;
        OrdenEnAula1 _ordenAulaLlena;

        public void listar()
		{
			foreach (var elem in elementos)
			{
				Console.Write(elem.ToString() + " \n ");
			}
			Console.WriteLine();
		}

        #region Coleccionable
        public void agregar(Comparable comparable)
        {
            if (this._ordenInicio != null) // si esta vacio el metodo es usado solo para agregar un comparable a la lista
            {
                if (this.elementos.Count == 0)
                {
                    this._ordenInicio.ejecutar();
                }
                this._ordenLlegaAlumno.ejecutar(comparable);
                this.elementos.Add(comparable);
                if (this.elementos.Count == 40)
                {
                    this._ordenAulaLlena.ejecutar();
                }
            }
            else
            {
                this.elementos.Add(comparable);
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
        public int cuantos()
        {
            return this.elementos.Count;
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
        #endregion
        public Comparable desencolar()
		{
			Comparable dato = this.elementos[0];
			this.elementos.RemoveAt(0);
			return dato;
		}
		public bool esVacia()
		{
			return this.elementos.Count == 0;
		}
		public Comparable Tope()
		{
			return this.elementos[0];
		}

        public Iterador crearIterador()
        {
            return new IteradorDePila(this.elementos);
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
