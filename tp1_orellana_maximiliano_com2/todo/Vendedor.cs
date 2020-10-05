using System;
using System.Collections.Generic;
using System.Text;
using tp1.clases_TP3;

namespace tp1
{
    class Vendedor : Persona, Sujeto
    {
        protected List<Observer> observer = new List<Observer>();
        protected int sueldoBasico { get; set; }
        public double bonus { get; set; }
        protected int ultimaVenta { get; set; }
        public Vendedor(string nombre, int dni, int sueldo) : base(nombre, dni)
        {
            this.sueldoBasico = sueldo;
            this.bonus = 1;
        }
        public Vendedor(){}
        public int getUltimaVenta()
        {
            return this.ultimaVenta;
        }
        public virtual void venta(int monto)
        {
            this.ultimaVenta = monto;
            Console.WriteLine("El vendedor {0} hizo una venta de ${1}.", this, monto);
            this.notificar();
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
        #region interfas de observables

        public void agregar(Observer observador)
        {
            this.observer.Add(observador);
        }

        public void Quitar(Observer observador)
        {
            this.observer.Remove(observador);
        }

        public void notificar()
        {
            foreach (Observer ob in observer)
            {
                ob.actualizar(this);
            }
        }
        #endregion
       
    }
}
