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
            Console.WriteLine("Would you like a list of natural number, prime, Fibonacci, even or odd numbers?");
            Console.WriteLine("");

            string command = Console.ReadLine().ToLower();

            //User enters how many numbers should be printed.
            Console.WriteLine($"How many {command} should I print? Your number must be less than 30.");

            string how_many = Console.ReadLine();
            //int final_how_many = Int32.Parse(how_many);
            int final_how_many = Convert.ToInt32(how_many);

            // *When do I check if the "How Many" response is too big? 
            if (final_how_many > 30)
            {
                Console.WriteLine("Sorry, that number is bigger than 30, try again!");
                Console.ReadKey(); // or restart? how?
                goto Start;
            }
            else
            {
                //Then prints the the requested list of numbers space separated on the following line.
                Console.WriteLine($"Cool, I'm going to print {final_how_many} {command}. ok?");
            }
            if (command == "natural number")
            {
                //instantiate NaturalNumber
                //NaturalNumber myNaturalNumber = new NaturalNumber();
                
            }

            //*When should you actually create an instance of your class? now or later?
            // What about user-errors - did they enter a valid command?

            Console.WriteLine("Press any key to exit - have a great day!");
            Console.ReadKey();
        }
    }
}
