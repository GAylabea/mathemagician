using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Even : Integer
    {
        private int First { get; set; }

        // a constructor - must be public, no return type; matches the name of the class
        public Even()
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

            return current + 2;
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

