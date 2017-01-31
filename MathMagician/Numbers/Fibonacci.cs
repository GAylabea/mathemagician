using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        public FibonacciNumber()
        {
            First = 1;
            Step = 0;
        }
        public override int GetNext(int current)
        {
            return 1;
        }

        public new int[] GetSequence(int final_how_many)
        {
            int[] numbers = new int[final_how_many];
            int firstnumber = 1, 
                secondnumber = 1, 
                thirdnumber = 0;
            while (thirdnumber < final_how_many)
            {
                thirdnumber = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = thirdnumber;
            }
            return numbers;
        }
    }

}
