using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6_Patron_Template_Method
{
    class JuegoPiloto : Juego
    {
        Persona p1, p2;
        Persona Turno;
        List<int> _mazo;
        List<int> cartasP1 = new List<int>();
        List<int> cartasP2 = new List<int>();
        int[] idx;

        public JuegoPiloto()
        {
            this._mazo = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            idx = new int[] { 1, 1 };
            Turno = null;
            int carta;
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                carta = r.Next(1, 12);
                if (!cartasP2.Contains(carta))
                {
                    cartasP2.Add(carta);
                }
            }

            for (int i = 1; i <= 12; i++)
            {
                if (!cartasP1.Contains(i))
                {
                    cartasP2.Add(i);
                }
            }
        }

        public override bool hayGanador()
        {
            throw new NotImplementedException();
        }

        public override void jugarMano()
        {
            throw new NotImplementedException();
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
            for (int i = 0; i < _mazo.Count; i++)
            {
                this.cartasP1.Add(_mazo[i++]);
                this.cartasP2.Add(_mazo[i]);
            }
            Console.WriteLine("Se repartieron las cartas");
        }
    }
}
