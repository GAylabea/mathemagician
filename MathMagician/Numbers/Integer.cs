using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    //your classes must inherit from this class; you should have implementations AND tests for each 
    interface Integer
    {
        int GetFirst(); //first number in sequence of numbers printed to the screen for ALL classes
        int GetNext(int current); //given the current number, find a way to print the next (according to command)
        int[] GetSequence(int final_how_many); //a resulting array
        string PrintNumbers(int[] how_many); //the list to print to the screen
    }
}
