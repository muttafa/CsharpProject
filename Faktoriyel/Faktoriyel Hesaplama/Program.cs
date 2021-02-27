using System;

namespace Faktoriyel_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Faktoriyeli hesaplanacak olan sayıyı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = sayi ; i> 0; i--)
            {
                
                faktoriyel *= i;
                
            }
            Console.WriteLine("{0} sayisinin faktoriyeli :{1}",sayi,faktoriyel);
        }
    }
}
