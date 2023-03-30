using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of dice: ");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int dice = random.Next(1, 7);
                Console.WriteLine("Dice {0}: {1}", i + 1, dice);
                sum += dice;
            }

            Console.WriteLine("Total sum: {0}", sum);
        }
    }
}

