using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinues = true;
            while (ProgramContinues == true)
            {
                long userInput;
                Console.WriteLine("Please enter an integer between 1 and 10");
                userInput = long.Parse(Console.ReadLine());

                long fact = userInput;

                for (long i = userInput; i <= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine(fact);

                string userChoice;
                Console.WriteLine("Would you like to continue?");
                userChoice = Console.ReadLine();
                if (userChoice == "No" || userChoice == "no")
                {
                    ProgramContinues = false;
                }


            }
        }
    }
}
