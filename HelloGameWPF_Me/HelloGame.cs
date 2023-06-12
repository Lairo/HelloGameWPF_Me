using System;

namespace HelloGameWPF_Me
{
    internal class HelloGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();

        private int currentNumber = random.Next(1, MAXIMUM + 1);
        private int nextNumber = random.Next(1, MAXIMUM + 1);
        private int pot = 10;

        public string Cheat()
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

        public int Pot
        {
            get { return pot; }
            set { pot = value; }
        }

        public int CurrentNumber
        {
            get { return currentNumber; }
            set
            {
                currentNumber = value;
            }
        }

        public int NextNumber
        {
            get { return nextNumber; }
            set
            {
                nextNumber = value;
            }
        }


        public string Guess(bool higher)
        {
            string prompt;
            if ((NextNumber >= CurrentNumber && higher) || (NextNumber <= CurrentNumber && !higher))
            {
                prompt = "Correct!";
                Pot++;
            }
            else
            {
                prompt = "Wrong.";
                Pot--;
            }

            CurrentNumber = NextNumber;
            NextNumber = random.Next(1, MAXIMUM + 1);
            return prompt;
        }

        public string Hint()
        {
            float half = (float)NextNumber / 2;
            string hint = $"At least {half}.";
            Pot--;
            return hint;

        }

        public HelloGame()
        {

        }

    }
}
