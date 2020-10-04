using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;

namespace tp1
{
    class Seguridad : Observer
    {
        public void actualizar(Sujeto pauperrimo)
        {
            VendedorPauperrimo paupe = (VendedorPauperrimo)pauperrimo;
            if (paupe.getUltimaVenta() < 500 )
            {
                this.reaccionar();
            }
        }

        public void reaccionar()
        {
            Console.WriteLine("El seguridad llamo la atencion.");
        }
    }
}
