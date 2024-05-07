using System;

namespace FinalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Age Calculator!");
            Console.WriteLine("What is your birthday? (YYYY-MM-DD):");

            DateTime birthday;
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.WriteLine("Invalid input. Please enter your birthday in the format YYYY-MM-DD:");
            }


            TimeSpan ageInDays = DateTime.Now - birthday;

         
            Console.WriteLine($"Your age in days is: {ageInDays.TotalDays}");

            Console.ReadLine();
        }
    }
}
