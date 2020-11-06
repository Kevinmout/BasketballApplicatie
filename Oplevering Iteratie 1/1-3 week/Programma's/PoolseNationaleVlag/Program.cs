using System;
using System.Collections.Generic;

namespace PoolseNationaleVlag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stones = { "white", "red", "white", "red" ,"white","white","red"};
            for (int i = 0; i < stones.Length - 1; i++)
            {
                if (stones[i] == "white" && stones[i + 1] == "red")
                {
                    stones[i + 1] = "white";
                    stones[i] = "red";
                    i = 0;
                }
            }
            foreach (string item in stones)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}


