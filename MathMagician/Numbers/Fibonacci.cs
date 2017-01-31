using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        // this is one option - it could hold a basic sequence of 1, 1, 2, 3, 5, 8
        // this way makes it possible to inherit from NaturalNumber (*need to correct/add this in your test)
        private int[] BaseSequence { get; set; }
    }

}
