using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
{
    public class Persona : IComparable
    {
        public virtual string nombre { get; set; }
        public virtual int dni { get; set; }

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public Persona() { }

        public virtual string getNombre()
        {
            return this.nombre;
        }
        public int getDNI()
        {
            return this.dni;
        }

        public virtual bool sosIgual(IComparable comparable)
        {
            return this.dni == ((Persona)comparable).getDNI();
        }
        public virtual bool sosMenor(IComparable comparable)
        {
            if (this.getDNI() < ((Persona)comparable).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool sosMayor(IComparable comparable)
        {
            if (this.getDNI() > ((Persona)comparable).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format(this.nombre);
        }
    }
}
