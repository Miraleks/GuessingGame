using System;

namespace GuessingGame.BL
{
    class Generator
    {
        public static int GenerateNewNumber(int fromValue, int endValue)
        {
            Random random = new Random();

            int number = random.Next(fromValue, endValue);

            return number;

        }

    }
}
