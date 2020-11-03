﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6_Patron_Template_Method
{
    abstract class Juego
    {
        protected Persona _turno;
        public Persona jugar()
        {  
            mezclarMazo();
            repartir();
            while (!hayGanador())
            {
               jugarMano();
            }
            return _turno;

        }
        public abstract void mezclarMazo();
        public abstract void repartir();
        public abstract void jugarMano();
        public abstract bool hayGanador();

        public void tomarCartas(Persona j) {
            Console.WriteLine("el jugador {0} tomo una carta", j);
        }
        public void descartar(Persona j)
        {
            Console.WriteLine("el jugador {0} descarto una carta", j);
        }
    }
}