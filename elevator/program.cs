using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ElevatorChallenge
{
    class Program
    {
        public static bool QUIT = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this elevator example.");
            Console.WriteLine("Press 'Q' to finish current Queue and exit example.");
            Console.WriteLine("------------------------------------------------------------------");

            string input = Console.ReadLine();
            if (input == "q" || input == "Q")
            {
                QUIT = true;
            }
            Console.WriteLine();

            
        }
    }
}