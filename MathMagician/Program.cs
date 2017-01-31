using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            //User enters a command, then presses enter
            Console.WriteLine("Would you like a list of natural, prime, Fibonacci, even or odd numbers?");
            Console.WriteLine("");
            string command = Console.ReadLine().ToLower();

            //User enters how many numbers should be printed.
            Console.WriteLine($"How many {command} should I print? Your number must be less than 30.");

            string how_many = Console.ReadLine();
            int final_how_many = Int32.Parse(how_many);

            // *When do I check if the "How Many" response is too big? 
            if (final_how_many > 30)
            {
                Console.WriteLine("Sorry, that number is bigger than 30, try again!");
                Console.ReadKey(); 
                goto Start;
            }
            else
            {
                //Then prints the the requested list of numbers space separated on the following line.
                Console.WriteLine($"Great, I'm going to print {how_many} {command} numbers. ok?");
            }
            if (command == "natural")
            {
                //instantiate NaturalNumber
                Numbers.NaturalNumber myNaturalNumber = new Numbers.NaturalNumber();
                myNaturalNumber.GetFirst();
                myNaturalNumber.GetNext(1);
                int[] naturalArray = myNaturalNumber.GetSequence(final_how_many);
                Console.WriteLine(myNaturalNumber.PrintNumbers(naturalArray));
                
            }
            else if (command == "even")
            {
                Numbers.EvenNumber myEvenNumber = new Numbers.EvenNumber();
                myEvenNumber.GetFirst();
                myEvenNumber.GetNext(4);
                int[] evenArray = myEvenNumber.GetSequence(final_how_many);
                Console.WriteLine(myEvenNumber.PrintNumbers(evenArray));
            }
            else if (command == "odd")
            {
                Numbers.OddNumber myOddNumber = new Numbers.OddNumber();
                myOddNumber.GetFirst();
                myOddNumber.GetNext(3);
                int[] oddArray = myOddNumber.GetSequence(final_how_many);
                Console.WriteLine(myOddNumber.PrintNumbers(oddArray));
            }
            else if (command == "fibonacci")
            {
                Numbers.FibonacciNumber myFibonacciNumber = new Numbers.FibonacciNumber();
                int[] fibArray = myFibonacciNumber.GetSequence(final_how_many);
                Console.WriteLine(myFibonacciNumber.PrintNumbers(fibArray));
            }
            //*When should you actually create an instance of your class? now or later?
            // What about user-errors - did they enter a valid command?

            Console.WriteLine("Press any key to exit - have a great day!");
            Console.ReadKey();
        }
    }
}
