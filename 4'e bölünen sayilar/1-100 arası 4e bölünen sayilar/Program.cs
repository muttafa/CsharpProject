using System;

namespace _1_100_arası_4e_bölünen_sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%4==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
