using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
{
    abstract class Juego
    {
        protected Persona[] jugadores;
        protected Persona _turno;
        public Persona jugar(Persona p1, Persona p2)
        {
            jugadores = new Persona[] { p1, p2 };

            mezclarMazo();
            repartir();
            while (!hayGanador())
            {
                if (_turno == jugadores[0])
                {
                    _turno = jugadores[1];
                }else
                {
                    _turno = jugadores[0];
                }
                tomarCartas();
                descartar();
            }
            mostrarGanador();
            return _turno;
        }

        public Persona jugarPartida(Persona p1, Persona p2)
        {
            int[] puntos = new int[] { 0, 0 };
            Persona GanadorMano = null;
            while (puntos[0] < 3 && puntos[1] < 3)
            {
                GanadorMano = jugar(p1, p2);
                if (GanadorMano == jugadores[0])
                {
                    puntos[0]++;
                }else
                {
                    puntos[1]++;
                }
            }
            return GanadorMano;
        }
        public abstract void mezclarMazo();
        public abstract void repartir();
        public abstract bool hayGanador();

        public abstract void tomarCartas();
        public abstract void descartar();
        public abstract void mostrarGanador();

    }
}
