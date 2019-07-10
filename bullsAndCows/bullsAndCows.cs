using System;

namespace bullsAndCows
{
    class bullsAndCows
    {
        static void Main()
        {
            int guessNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool foundNumber = false;

            for (int i = 1000; i < 9999; i++)
            {
                int currentNumber = i;
                int currentBulls = 0;
                int currentCows = 0;

                int currentD = currentNumber % 10;
                currentNumber /= 10;
                int currentC = currentNumber % 10;
                currentNumber /= 10;
                int currentB = currentNumber % 10;
                currentNumber /= 10;
                int currentA = currentNumber % 10;

                if (currentA == 0 || currentB == 0 || currentC == 0 || currentD == 0)
                {
                    continue;
                }

                int tempGuessNumber = guessNumber;
                int guessNumberD = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                int guessNumberC = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                int guessNumberB = tempGuessNumber % 10;
                tempGuessNumber /= 10;
                int guessNumberA = tempGuessNumber % 10;

                #region Find Bulls
                if (currentA == guessNumberA)
                {
                    currentBulls++;
                    currentA = -1; //change values of current and guess numbers so they wont be referred later
                    guessNumberA = -2;
                }

                if (currentB == guessNumberB)
                {
                    currentBulls++;
                    currentB = -1; //change values of current and guess numbers so they wont be referred later
                    guessNumberB = -2;
                }

                if (currentC == guessNumberC)
                {
                    currentBulls++;
                    currentC = -1; //change values of current and guess numbers so they wont be referred later
                    guessNumberC = -2;
                }

                if (currentD == guessNumberD)
                {
                    currentBulls++;
                    currentD = -1; //change values of current and guess numbers so they wont be referred later
                    guessNumberD = -2;
                }
                #endregion
                #region currentA
                if (currentA == guessNumberB)
                {
                    currentCows++;
                    currentA = -1;
                    guessNumberB = -2;
                }
                if (currentA == guessNumberC)
                {
                    currentCows++;
                    currentA = -1;
                    guessNumberC = -2;
                }
                if (currentA == guessNumberD)
                {
                    currentCows++;
                    currentA = -1;
                    guessNumberD = -2;
                }
                #endregion
                #region currentB
                if (currentB == guessNumberA)
                {
                    currentCows++;
                    currentB = -1;
                    guessNumberA = -2;
                }
                if (currentB == guessNumberC)
                {
                    currentCows++;
                    currentB = -1;
                    guessNumberC = -2;
                }
                if (currentB == guessNumberD)
                {
                    currentCows++;
                    currentB = -1;
                    guessNumberD = -2;
                }
                #endregion
                #region currentC
                if (currentC == guessNumberA)
                {
                    currentCows++;
                    currentC = -1;
                    guessNumberA = -2;
                }
                if (currentC == guessNumberB)
                {
                    currentCows++;
                    currentC = -1;
                    guessNumberB = -2;
                }
                if (currentC == guessNumberD)
                {
                    currentCows++;
                    currentC = -1;
                    guessNumberD = -2;
                }
                #endregion
                #region currentD
                if (currentD == guessNumberA)
                {
                    currentCows++;
                    currentD = -1;
                    guessNumberA = -2;
                }
                if (currentD == guessNumberB)
                {
                    currentCows++;
                    currentD = -1;
                    guessNumberB = -2;
                }
                if (currentD == guessNumberC)
                {
                    currentCows++;
                    currentD = -1;
                    guessNumberC = -2;
                }
                #endregion

                if (currentBulls == bulls && currentCows == cows)
                {
                    foundNumber = true;
                    Console.Write("{0} ", i);
                }
            }
            if (!foundNumber)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
