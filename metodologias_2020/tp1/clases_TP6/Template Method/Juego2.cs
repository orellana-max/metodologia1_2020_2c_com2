using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace practica_6_Ejercicio_3
{
    class Juego2 : Juego
    {
        List<int> _mazo;
        List<int> _cartasJ1;
        List<int> _cartasJ2;

        int idx = 0;
        int CartaJugada;

        public Juego2()
        {
            this._mazo = new List<int>();
            for (int i = 1; i <= 50; i++)
            {
                this._mazo.Add(i);
            }
            _turno = null;
        }

        public override bool hayGanador()
        {
            if (idx == 20)
            {
                Console.WriteLine("Hay ganador.");
                return true;
            }
            else { return false; }
        }
        public override void mezclarMazo()
        {
            Random r = new Random();
            int aux, azar;
            for (int i = 0; i < _mazo.Count; i++)
            {
                aux = _mazo[i];
                azar = r.Next(_mazo.Count);
                _mazo[i] = _mazo[azar];
                _mazo[azar] = aux;
            }
            Console.WriteLine("El mazo está Mezclado.");
        }
        public override void repartir()
        {
            idx = 0;
            _cartasJ1 = new List<int>();
            _cartasJ2 = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                _cartasJ1.Add(_mazo[idx++]);
                _cartasJ2.Add(_mazo[idx++]);
            }
            Console.WriteLine("Se repartieron las cartas");
        }
        public override void tomarCartas()
        {
            int d = new Random().Next(3);
            int aux = _mazo[idx++];
            if (_turno == jugadores[0])
            {
                CartaJugada = _cartasJ1[d];
                _cartasJ1[d] = aux;
                Console.WriteLine("El jugador 1 tomó una carta.");
            }
            else
            {
                CartaJugada = _cartasJ2[d];
                _cartasJ2[d] = aux;
                Console.WriteLine("El jugador 2 tomó una carta.");
            }
        }
        public override void descartar()
        {
            Console.WriteLine("El jugador {0} descartó una carta.", _turno == jugadores[0] ? "1" : "2");
        }
        public override void mostrarGanador()
        {
            int puntos1 = 0;
            int puntos2 = 0;

            foreach (int item in _cartasJ1)
            {
                puntos1 += item;
            }
            foreach (int item in _cartasJ2)
            {
                puntos2 += item;
            }
            Console.WriteLine("Puntos J1: {0}.\nPuntos J2 {1}.",puntos1, puntos2);
            if (puntos1 == puntos2)
            {
                Console.WriteLine("Hay empate");
                _turno = null;
            }
            else
            {
                if (puntos1 > puntos2)
                {
                    _turno = jugadores[0];
                }
                else
                {
                    _turno = jugadores[1];
                }
                Console.WriteLine("Gano el jugador {0}", (puntos1 > puntos2) ? this.jugadores[0] : this.jugadores[1]);
            }
        }
    }
}
