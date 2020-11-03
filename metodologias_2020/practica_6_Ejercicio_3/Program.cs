using System;

namespace practica_6_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jugamos un Juego con Template Method");
            Persona p1 = new Persona("Jugador1");
            Persona p2 = new Persona("Jugador2");
            Juego juego2 = new Juego2();
            juego2.jugar(p1, p2);
        }
    }
}
