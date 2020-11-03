﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6_Patron_Template_Method
{
    class JuegoPiloto : Juego
    {
        Persona p1, p2;
        List<int> _mazo;
        int CartaJugada;

        public JuegoPiloto(Persona p1, Persona p2)
        {
            this.p1 = p1;
            this.p2 = p2;

            this._mazo = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            CartaJugada = 0;
            _turno = null;
        }

        public override bool hayGanador()
        {
            if (CartaJugada == 1)
            {
                return true;
            }
            else { return false; }
        }

        public override void jugarMano()
        {

            Console.WriteLine("Juega Mano.");
            if (this._turno == p1)
                this._turno = p2;
            else
                this._turno = p1;

            tomarCartas(_turno);
            descartar(_turno);
            CartaJugada++;
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
            Console.WriteLine("El mazo esta Mezclado.");
        }

        public override void repartir()
        {
            //for (int i = 0; i < _mazo.Count; i++)
            //{
            //    this.cartasP1.Add(_mazo[i++]);
            //    this.cartasP2.Add(_mazo[i]);
            //}
            Console.WriteLine("Se repartieron las cartas");
        }
    }
}