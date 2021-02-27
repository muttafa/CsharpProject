using System;

namespace Sayı_Tahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int puan = 0;
            Console.WriteLine("Bir ile 100 arasında bir sayı girin :");
            int sayi = int.Parse(Console.ReadLine());

            int pc = rnd.Next(1, 100);

            if (pc == sayi)
            {
                Console.WriteLine("!!!Tebrikler Sayıyı bildiniz!!!");
                puan++;
            }
            else
            {
                Console.WriteLine("Bilemediniz...Sayı :"+pc);
                Console.WriteLine("puanınız :"+puan);
            }
        }
    }
}
