using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }

        // One approach is to use a list to hold calculated numbers
        //private List<int> sequence { get; set; }


        public NaturalNumber()
        {
            First = 1;
            Step = 1;
            // this.First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        virtual public int GetNext(int current)
        {
            // 'current' argument is read-only
            return current + Step;

        }

        public int[] GetSequence(int final_how_many)
        {
            int[] numbers = new int[final_how_many];
            numbers[0] = GetFirst(); // i = 1
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