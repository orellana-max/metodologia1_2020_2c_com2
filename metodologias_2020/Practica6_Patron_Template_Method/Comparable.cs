﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica6_Patron_Template_Method
{
    public interface IComparable
    {
        bool sosIgual(IComparable comparable);
        bool sosMenor(IComparable comparable);
        bool sosMayor(IComparable comparable);


    }
}