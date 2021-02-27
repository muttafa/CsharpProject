using System;

namespace Ebob_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayiyi Giriniz :");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayiyi Giriniz :");
            int sayi2 = int.Parse(Console.ReadLine());
            int ebob = 0;
            if (sayi1>sayi2)
            {
                int i = 1;
                while (i<=sayi2)
                {
                    if (sayi1%i == 0 && sayi2%i==0)
                    {
                        ebob = i;
                    }
                    i++;
                }
            }
            else if (sayi2>sayi1)
            {
                int i = 1;
                while (i <= sayi1)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        ebob = i;
                    }
                    i++;
                }
            }
            Console.WriteLine(ebob);


        }
    }
}
