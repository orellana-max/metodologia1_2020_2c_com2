﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using tp1.Iterator;

namespace tp1.clases_TP2
{
    class Diccionario : Coleccionable
    {
        List<ClaveValor> elementos = new List<ClaveValor>();

        public void agregar(Comparable clave, Comparable valor)
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
        public Comparable valorDe(Comparable clave)
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
            Random ran = new Random();
            bool existe = true;
            Numero num = new Numero(ran.Next(0, 500));
            while (existe)
            {
                existe = false;
                num = new Numero(ran.Next(0, 500));

                foreach (ClaveValor ele in elementos)
                {
                    if (ele.getClave().sosIgual(num)) // si las claves son iguales
                    {
                        existe = true;
                        break;
                    }
                }
            }
            
            ClaveValor claveValor = new ClaveValor(num, comparable);
            elementos.Add(claveValor);
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

        public Iterador crearIterador()
        {
            return new IteradorDeDiccionario(this.elementos);
        }
    }
}

