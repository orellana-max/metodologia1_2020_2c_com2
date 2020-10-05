using System;
using System.Collections.Generic;
using System.Text;

namespace tp1.clases_TP3
{
    interface Sujeto
    {
        void agregar(Observer observador);
        void Quitar(Observer observador);
        void notificar();

    }
}