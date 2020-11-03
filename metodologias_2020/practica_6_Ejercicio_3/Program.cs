using System;

namespace practica_6_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jugamos un Juego con Template Method");
            Persona p1 = new Persona("Nombre_Jugador1");
            Persona p2 = new Persona("Nombre_Jugador2");
            Juego juego2 = new Juego2();
            juego2.jugar(p1, p2);
        }
    }
}
