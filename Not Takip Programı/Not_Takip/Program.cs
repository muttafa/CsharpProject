using System;

namespace Not_Takip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu projede öğrencinin dersten geçip geçmediğini hesaplayan basit bir program yazdım...
            Console.WriteLine("Merhaba Lütfen Kısa Sınav Puanınızı Giriniz : ");
            int ks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Kısa Sınav Puanınızı Giriniz : ");
            int ks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Vize Sınav Puanınızı Giriniz : ");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Final Sınav Puanınızı Giriniz : ");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = (ks1 / 10 + ks2 / 10 + (3 * vize / 10) + final / 2);
            Console.WriteLine("Ortalamanız :"+ortalama);
            double harf = ortalama / 25;
            switch (harf)
            {
                case 1: Console.WriteLine("Harf notunuz ff dir .. KALDINIZ!!");
                    break;
                case 1.5: Console.WriteLine("Harf notunuz dd dir.Kıl payı geçtiniz");
                    break;
                case 2: Console.WriteLine("Harf notunuz cc dir.");
                    break;
                case 3: Console.WriteLine("Harf notunuz bb dir.");
                    break;
                case 4: Console.WriteLine("Harf notunuz aa dir.");
                    break;
                default:
                    break;
            }
        }
    }
}
