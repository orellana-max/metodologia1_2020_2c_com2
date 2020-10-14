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

        public void ejecutar(Comparable comparable)
        {
            this.aula.nuevoAlumno((Alumno)comparable);
        }
    }
}
