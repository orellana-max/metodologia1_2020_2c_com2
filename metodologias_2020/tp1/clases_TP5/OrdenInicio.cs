using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }
        /// <summary>
        /// ejecuta el metodo comenzar del aula.
        /// </summary>
        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }
}
