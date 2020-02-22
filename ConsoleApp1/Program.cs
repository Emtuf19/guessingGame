using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        const int maxTrials = 5;

        static void Main(string[] args)
        {            
            Console.WriteLine("Guess the name I'm thinking of");
            Console.WriteLine("It starts with g");

            string correctName = "gertrud";

            for (int i = 0; i < maxTrials; i++)
            {
                string guessedName = Console.ReadLine();

                if (guessedName == correctName)
                {
                    Console.WriteLine("Congratulations, You guessed it!");
                    Thread.Sleep(1300);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Wrong name, try again! tries left: " + ((maxTrials - 1) - i));
                }
            }
            
        }
    }
}
