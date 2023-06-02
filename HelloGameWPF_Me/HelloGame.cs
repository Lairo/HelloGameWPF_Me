using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGameWPF_Me
{
    internal static class HelloGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        static private int currentNumber = random.Next(1, MAXIMUM + 1);
        static private int nextNumber = random.Next(1, MAXIMUM + 1);
        static private int pot = 10;

        internal static void Cheat()
        {
            random = new Random(1);
            Random cheatRandom = new Random(1);
            Console.WriteLine("The first 20 numbers will be: ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write(cheatRandom.Next(1, MAXIMUM + 1) + " ");
            }
        }

        internal static int GetPot(){ return pot; }

        internal static void Guess(bool higher)
        {
            if ((nextNumber >= currentNumber && higher) || (nextNumber <= currentNumber && !higher))
            {
                Console.WriteLine("\nYou guessed right!");
                pot++;
            
            } else
            {
                Console.WriteLine("\nBad luck, you guessed wrong.");
                pot--;
            }

            currentNumber = nextNumber;
            nextNumber = random.Next(1, MAXIMUM + 1);
            Console.WriteLine($"\nThe current number is {currentNumber}.");
        }

        internal static void Hint()
        {
            float half = (float)nextNumber / 2;
            Console.WriteLine($"\nThe current number is {currentNumber}, the next is at least {half}.");
            pot--;
        }
    }
}
