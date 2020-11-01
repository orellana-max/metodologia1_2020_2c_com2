using System;

namespace practica_6_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jugamos un Juego con Template Method");
            Persona p1 = new Persona("Jugador1", 1);
            Persona p2 = new Persona("Jugador2", 2);
            Juego juegoDel1 = new JuegoPiloto(p1, p2);
            Persona ganador = juegoDel1.jugar();
            Console.WriteLine(ganador);
        }
    }
}
