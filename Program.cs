
using System;
namespace ConsoleApp1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberOfRolls = int.Parse(Console.ReadLine());

            DiceRoller diceRoller = new DiceRoller();
            int[] results = diceRoller.SimulateRolls(numberOfRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numberOfRolls);

            PrintHistogram(results);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        static void PrintHistogram(int[] results)
        {
            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": ");

                int percentage = results[i] * 100 / results.Length;
                int asterisks = percentage / 1;

                for (int j = 0; j < asterisks; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

