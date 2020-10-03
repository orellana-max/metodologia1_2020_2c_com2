using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class Vendedor : Persona
    {
        public int sueldoBasico { get; set; }
        public int bonus { get; set; }
        public Vendedor(string nombre, int dni, int sueldo) : base(nombre, dni)
        {
            this.sueldoBasico = sueldo;
            this.bonus = 1;
        }
        public void venta(int monto) {
            Console.WriteLine("El vendedor {0} hizo una venta de {1}.", this, monto);
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
