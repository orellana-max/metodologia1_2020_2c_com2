using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class Vendedor : Persona
    {
        public int sueldoBasico { get; set; }
        public double bonus { get; set; }
        public Vendedor(string nombre, int dni, int sueldo) : base(nombre, dni)
        {
            this.sueldoBasico = sueldo;
            this.bonus = 1;
        }
        public Vendedor(){}
        public void venta(int monto)
        {
            Console.WriteLine("El vendedor {0} hizo una venta de ${1}.", this, monto);
        }
        public void aumentaBonus()
        {
            this.bonus += 0.1;
        }

        #region comparaciones
        public override bool sosIgual(Comparable comparable)
        {
            return this.bonus == ((Vendedor)comparable).bonus;
        }
        public override bool sosMenor(Comparable comparable)
        {
            if (this.bonus < ((Vendedor)comparable).bonus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool sosMayor(Comparable comparable)
        {
            if (this.bonus > ((Vendedor)comparable).bonus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + " Bonus: " + this.bonus;
        }
    }
}
