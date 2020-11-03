using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
{
    abstract class Juego
    {
        protected Persona[] jugadores = new Persona[2];
        protected Persona _turno;
        public void jugar(Persona p1, Persona p2)
        {
            jugadores = new Persona[2];
            jugadores[0] = p1;
            jugadores[1] = p2;

            mezclarMazo();
            repartir();
            while (!hayGanador())
            {
                jugarMano();
            }
            mostrarGanador();
        }
        public abstract void mezclarMazo();
        public abstract void repartir();
        public abstract void jugarMano();
        public abstract bool hayGanador();

        public abstract void tomarCartas();
        public abstract void descartar();
        public abstract void mostrarGanador();

    }
}
