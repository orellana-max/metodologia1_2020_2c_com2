using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6_Patron_Template_Method
{
    abstract class Juego
    {
        Persona _turno;
        public Persona jugar(Persona p1, Persona p2)
        {  
            mezclarMazo();
            repartir();
            while (!hayGanador())
            {
                if (this._turno == p1)
                    this._turno = p2;
                else
                    this._turno = p1;

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
