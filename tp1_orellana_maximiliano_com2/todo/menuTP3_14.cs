using System;
using System.Collections.Generic;
using System.Text;
using tp1.Iterator;
using tp1.Strategy;
using tp1.clases_TP2;
using System.Runtime.CompilerServices;

namespace tp1.clases_TP3
{
    class menuTP3_14
    {
        public static void run()
        {
            Coleccionable coleccion = new Pila();
            llenar(coleccion, "3");
            Gerente gerente = new Gerente();
            Iterador iteradorPila = coleccion.crearIterador();
            while (!iteradorPila.fin())
            {
                ((Vendedor)(iteradorPila.actual())).agregar(gerente);
                iteradorPila.siguiente();
            }
            jornadaDeVentas(coleccion);
            gerente.cerrar();

        }
        static void llenar(Coleccionable coleccion, string opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                coleccion.agregar(comparable);
            }
        }
        public static void jornadaDeVentas(Coleccionable vendedores)
        {
            Iterador iterador = vendedores.crearIterador();
            Vendedor v = null;
            int monto;
            for (int i = 0; i < 20; i++)
            {
                while (!iterador.fin())
                {
                    v = (Vendedor)(iterador.actual());
                    monto = GeneradorDeDatosAleatorios.numeroAleatorio(7000);
                    v.venta(monto);
                    iterador.siguiente();
                }
            }
        }
    }
}
