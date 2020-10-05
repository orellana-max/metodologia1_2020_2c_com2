using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;

namespace tp1
{
    class VendedorPauperrimo : Vendedor, Sujeto
    {
        public VendedorPauperrimo(string n, int d, int s): base(n, d, s) {
        }
        public void robar()
        {
            Console.WriteLine("El vendedor robó un articulo.");
        }
        public void descansar()
        {
            Console.WriteLine("El vendedor pauperrimo descanza.");
        }
        public void molestarALosCompañeros()
        {
            Console.WriteLine("El vendedor pauperrimo esta molestando a los companeros");
        }
        public override void venta(int monto)
        {
            Console.WriteLine("El vendedor Pauperrimo {0} hizo una venta de ${1}.", this, monto);
            this.ultimaVenta = monto;
            if (monto < 500)
            {
                this.robar();
            }
            if (monto >= 500 && monto <= 4000) 
            {
                this.molestarALosCompañeros();
            }
            if (monto > 4000)
            {
                this.descansar();
            }
           
            this.notificar();
        }
        public override string ToString()
        {
            return this.nombre;
        }

    }
}
