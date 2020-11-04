using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
{
    class Juego1 : Juego
    {
        List<int> _mazo;
        int idx = 0;
        int cartaJugada;

        public Juego1()
        {
            this._mazo = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            _turno = null;
        }

        public override bool hayGanador()
        {
            if (cartaJugada == 1)
            {
                Console.WriteLine("Hay ganador.");
                return true;
            }
            else { return false; }
        }
     
        public override void mezclarMazo()
        {
            idx = 0;
            cartaJugada = 0;
            Random r = new Random();
            int aux, azar;
            for (int i = 0; i < _mazo.Count; i++)
            {
                aux = _mazo[i];
                azar = r.Next(_mazo.Count);
                _mazo[i] = _mazo[azar];
                _mazo[azar] = aux;
            }
            Console.WriteLine("El mazo esta Mezclado.");
        }

        public override void repartir()
        {
            Console.WriteLine("Se repartieron las cartas");
        }

        public override void tomarCartas()
        {
            Console.WriteLine("El jugador {0} tomo una carta.", _turno == jugadores[0] ? "1" : "2");
        }
        public override void descartar()
        {
            cartaJugada = _mazo[idx++];
            Console.WriteLine("El jugador {0} descarto una carta.", _turno == jugadores[0]  ? "1" : "2");
        }
        public override void mostrarGanador()
        {
            Console.WriteLine("Gano el jugador {0}", _turno == jugadores[0]  ? "1" : "2");
        }
    }
}
