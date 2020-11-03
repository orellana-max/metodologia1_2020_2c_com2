using System;
using System.Collections.Generic;
using System.Text;

namespace practica_6_Ejercicio_3
{
    public class Persona 
    {
        public virtual string nombre { get; set; }
       

        public Persona(string n)
        {
            this.nombre = n;
            
        }
        public Persona() { }

        public virtual string getNombre()
        {
            return this.nombre;
        }
 

        public override string ToString()
        {
            return String.Format(this.nombre);
        }
    }
}
