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


            //Might need to move this below section to another file
            Console.WriteLine("Please enter the floor of the passenger and direction they wish to go (EX. 4D or 7U). ");
            string floorRequest = Console.ReadLine();
            //Check if the rquest is from outside or inside
            if (floorRequest.Length = 2)
            {
                //split the string to grab the starting floor and passengers requested direction
                var floor = floorRequest.Substring(0, (int)(MyString.Length / 2));
                var direction = floorRequest.Substring((int)(MyString.Length / 2), (int)(MyString.Length / 2));
                Passenger = new Passenger(floor, direction);
            }
            else if (floorRequest.Length = 1)
            {
                
            }
        }
    }
}