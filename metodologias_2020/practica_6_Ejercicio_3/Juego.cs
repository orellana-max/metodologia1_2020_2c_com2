using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
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

        public abstract void tomarCartas(Persona j);
        public abstract void descartar(Persona j);
        
    }
}
