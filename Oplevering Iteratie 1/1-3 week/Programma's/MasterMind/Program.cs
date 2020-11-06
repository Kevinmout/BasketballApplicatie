using System;
using System.Collections.Generic;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Binair = new List<int> { 0, 1, 0, 1, 1 };
            List<int> Guess = new List<int> { 1, 1, 0, 0, 1 };

            int GuessedRight = 0;
            for (int i = 0; i < Binair.Count; i++)
            {
                if (Binair[i] == Guess[i])
                {
                    GuessedRight++;
                }
            }
            Console.WriteLine(GuessedRight.ToString());

        }
    }
}