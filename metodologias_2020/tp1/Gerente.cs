using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;

namespace tp1
{
    class Gerente: Observer
    {
        public List<Vendedor> mejores = new List<Vendedor>();

        public Gerente()
        {
        }

        public void actualizar(Sujeto sujeto)
        {
            Vendedor vendedor = (Vendedor)sujeto;
            this.venta(vendedor.ultimaVenta, vendedor);
        }

        public void cerrar()
        {
            foreach (Vendedor vendedor in mejores)
            {
                Console.WriteLine("El vendedor " + vendedor.nombre + ", con Bonus " + vendedor.bonus + ", esta en los mejores del día.");
            }

        }
        public void venta(int monto, Vendedor vendedor)
        {
            if (monto > 5000)
            {
                if (!mejores.Contains(vendedor)) 
                    this.mejores.Add(vendedor);

                vendedor.aumentaBonus();
            }
        }
    }
}
