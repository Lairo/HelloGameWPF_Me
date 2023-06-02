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

        internal static string Cheat()
        {
            random = new Random(1);
            Random cheatRandom = new Random(1);

            string cheatValue = " ";

            cheatValue += "The first 20 numbers will be: \n";

            for (int i = 0; i < 20; i++)
            {
                cheatValue += $"{cheatRandom.Next(1, MAXIMUM + 1)} ";
            }

            return cheatValue;
        }

        internal static int GetPot(){ return pot; }
        internal static int CurrentNumber() { return currentNumber; }
        internal static int NextNumber() {  return nextNumber; }

        internal static string Guess(bool higher)
        {
            string prompt = "";
            if ((nextNumber >= currentNumber && higher) || (nextNumber <= currentNumber && !higher))
            {
                prompt = "Correct!";
                pot++;
            
            } else
            {
                prompt = "Wrong.";
                pot--;
            }

            currentNumber = nextNumber;
            nextNumber = random.Next(1, MAXIMUM + 1);
            return prompt;
        }

        internal static string Hint()
        {
            float half = (float)nextNumber / 2;
            string hint = $"At least {half}.";
            pot--;
            return hint;
            
        }
    }
}
