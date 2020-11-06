using System;
using System.Linq;

namespace Pannenkoekensorteerder
{
    class Pannenkoek
    {
        static void Main(string[] args)
        {
            int[] pannenkoeken = { 5, 3, 9, 10};
            int[] order = { 5, 3, 9, 10 };
            Array.Sort(order);
            Array.Reverse(order);
            for (int i = 0; i < pannenkoeken.Length; i++)
            {
                foreach (int item in pannenkoeken)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                int aantal = Array.IndexOf(pannenkoeken, order[i]) + 1;
                for (int j = 0; j < (aantal) / 2; j++)
                {
                    int temp = pannenkoeken[j];
                    int a = pannenkoeken[aantal - j - 1];
                    pannenkoeken[j] = a;
                    pannenkoeken[aantal - j - 1] = temp;
                }
            }


            /*
            int aantal = 0;
            int lengte = pannenkoeken.Length - 1;
            for (int i = lengte; i <= 0 - 1; i--)
            {
                if (pannenkoeken[i] < pannenkoeken[i + 1])
                {
                    aantal = i + 2;
                }
                for (int j = 0; j < (aantal) / 2; j++)
                {
                    int temp = pannenkoeken[j];
                    int a = pannenkoeken[aantal - j - 1];
                    pannenkoeken[j] = a;
                    pannenkoeken[aantal - j - 1] = temp;
                }
            }
            */


            

        }
    }
}
