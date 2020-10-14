using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}
