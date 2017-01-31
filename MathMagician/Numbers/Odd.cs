using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class OddNumber : NaturalNumber
    {
        // a constructor - must be public, no return type; matches the name of the class
        public OddNumber()
        {
            First = 1;
            Step = 2;
        }

    }
}
