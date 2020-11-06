using System;
using System.Collections.Generic;

namespace CirkelVanSchakelaars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel lampen?");
            int aantalLampen = Convert.ToInt32(Console.ReadLine());
            List<int> lampen = new List<int>();
            List<int> schakelaars = new List<int>();
            for (int i = 0; i < aantalLampen; i++)
            {
                lampen.Add(0);
                schakelaars.Add(0);
            }

            Console.WriteLine("Selecteer schakelaar...");
            int geselecteerdeSchakelaar = Convert.ToInt32(Console.ReadLine());
            if (lampen[geselecteerdeSchakelaar] == 0)
            {
                Console.WriteLine("Wilt u de lampen aanzetten?(Y/N)");
                string invoer = Console.ReadLine().ToUpper();
                if (invoer == "Y" && geselecteerdeSchakelaar > 0)
                {
                    lampen[geselecteerdeSchakelaar - 1] = 1;
                    lampen[geselecteerdeSchakelaar] = 1;
                    lampen[geselecteerdeSchakelaar + 1] = 1;
                }
                else if (geselecteerdeSchakelaar == 0)
                {
                    lampen[lampen.Count - 1] = 1;
                    lampen[geselecteerdeSchakelaar] = 1;
                    lampen[geselecteerdeSchakelaar + 1] = 1;
                }
            }
            else
            {
                Console.WriteLine("Wilt u de lampen uitzetten?(Y/N)");
                string invoer = Console.ReadLine().ToUpper();
                if (invoer == "Y")
                {
                    lampen[geselecteerdeSchakelaar - 2] = 0;
                    lampen[geselecteerdeSchakelaar - 1] = 0;
                    lampen[geselecteerdeSchakelaar] = 0;
                }
            }

            foreach (int item in lampen)
            {
                Console.WriteLine(item);
            }
        }
    }
}
