using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Persona : Comparable
    {
        public virtual string nombre { get; set; }
        public virtual int dni { get; set; }

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public Persona() { }

        public string getNombre()
        {
            return this.nombre;
        }
        public int getDNI()
        {
            return this.dni;
        }

        public virtual bool sosIgual(Comparable comparable)
        {
            return this.dni == ((Persona)comparable).getDNI();
        }
        public virtual bool sosMenor(Comparable comparable)
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
        public virtual bool sosMayor(Comparable comparable)
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
            return String.Format(this.nombre + " DNI: " + this.getDNI().ToString());
        }
    }
}
