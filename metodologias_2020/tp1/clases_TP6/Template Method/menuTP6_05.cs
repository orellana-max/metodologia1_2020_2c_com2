using System;

namespace practica_6_Ejercicio_3
{
    class menuTP6_05
    {
        public static void run()
        {
            Console.WriteLine("Jugamos un Juego con Template Method");
            Persona p1 = new Persona("Nombre_Jugador1");
            Persona p2 = new Persona("Nombre_Jugador2");
            Juego juego = new Juego2();
            Persona Ganador = juego.jugarPartida(p1, p2);
            Console.WriteLine("El ganador del juego es " + Ganador.nombre);
        }
    }
}
