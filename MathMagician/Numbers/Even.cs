﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber   
    {
        // a constructor - must be public, no return type; matches the name of the class
        public EvenNumber()
        {
            First = 2;
            Step = 2;
        }

    }
}

