using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP2;

namespace tp1.clases_TP3
{
    public abstract class FabricaDeColeccionables
    {
        //public abstract Comparable CrearAleatorio();
        //public abstract Comparable CrearPorTeclado();

        public static Coleccionable crearColeccionable(string opcion)
        {
            FabricaDeColeccionables fabrica = null;

            if (opcion == "1")
                fabrica = new FabricaDePila();
            if (opcion == "2")
                fabrica = new FabricaDeCola();
            if (opcion == "3")
                fabrica = new FabricaDeConjunto();
            if (opcion == "4")
                fabrica = new FabricaDeDiccionario();

            return fabrica.CrearColeccionable();
        }
        public abstract Coleccionable CrearColeccionable();
    }

    class FabricaDePila : FabricaDeColeccionables
    {
        public override Coleccionable CrearColeccionable()
        {
            return new Pila();
        }
    }
    class FabricaDeCola : FabricaDeColeccionables
    {
        public override Coleccionable CrearColeccionable()
        {
            return new Cola();
        }
    }
    class FabricaDeConjunto : FabricaDeColeccionables
    {
        public override Coleccionable CrearColeccionable()
        {
            return new Conjunto();
        }
    }
    class FabricaDeDiccionario : FabricaDeColeccionables
    {
        public override Coleccionable CrearColeccionable()
        {
            return new Diccionario();
        }
    }
}