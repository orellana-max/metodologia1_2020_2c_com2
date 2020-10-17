using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP5
{
    class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }
        /// <summary>
        /// ejecuta el mensaje nuevoAlumno(comparable) para el Aula
        /// </summary>
        /// <param name="comparable"> Alumno para agregar a Aula </param>
        public void ejecutar(Comparable comparable)
        {
            this.aula.nuevoAlumno((Alumno)comparable);
        }
    }
}
