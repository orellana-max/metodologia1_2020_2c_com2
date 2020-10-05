using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;

namespace tp1
{
    class Encargado: Observer
    {
        public void actualizar(Sujeto pauperrimo)    
        {
            VendedorPauperrimo paupe = (VendedorPauperrimo)pauperrimo;
            if (paupe.getUltimaVenta() >= 500 && paupe.getUltimaVenta() <= 4000)
            {
                this.reaccionar();
            }
        }

        public void reaccionar()
        {
            Console.WriteLine("El encargado llamo la atencion al vendedor pauperrimo.");
        }
    }
}
