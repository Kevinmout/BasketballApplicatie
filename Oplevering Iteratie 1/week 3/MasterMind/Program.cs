using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string binair = Console.ReadLine();
             



            int[] Guess = new int[binair.Length];

            for (int i = 0; i < binair.Length; i++)
            {
                Guess[i] = random.Next(0,2);
            }

            int GuessedRight = 0;
            for (int i = 0; i < binair.Length; i++)
            {
                if (arrBinair[i] == Guess[i])
                {
                    GuessedRight++;
                }
            }
            Console.WriteLine(GuessedRight.ToString());

        }
    }
}