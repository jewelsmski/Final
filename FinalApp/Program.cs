using System;

namespace FinalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your birthday? (YYYY-MM-DD):");

            DateTime birthday;
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.WriteLine("Invalid input. Please enter your birthday in the format YYYY-MM-DD:");
            }


            TimeSpan ageInDays = DateTime.Now - birthday;

         
            Console.WriteLine($"You are {ageInDays.TotalDays} days old!");

            Console.ReadLine();
        }
    }
}
