using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers //because it is inside the Numbers folder, the namespace has a .Numbers
{
    public class NaturalNumber : Integer //any code outside the class can access it and its items per "public"
    {
        // default/dynamic implementation - it's private so it won't use anything else besides Integer
        // BUT make sure all of your methods are "public" so that everyone else can use them
        private int First { get; set; }

        // a constructor - must be public, no return type; matches the name of the class
        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;  these are equal - "this" means the current class instance
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            // 'current' argument is read-only; you cannot change its value

            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst();
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 1]);
            }

            return numbers;
        }

        public string PrintNumbers(int[] number_array)
        {
            return String.Join(" ", number_array);
        }
    }
}
