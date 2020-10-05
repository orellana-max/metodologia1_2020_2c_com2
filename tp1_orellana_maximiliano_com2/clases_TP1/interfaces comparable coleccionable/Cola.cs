﻿using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;

namespace tp1
{
	class Cola : Coleccionable
	{
        List<Comparable> elementos = new List<Comparable>();
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
			this.elementos.Add(comparable);
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
    }
}