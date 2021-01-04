using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_Simple_Guess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zorluğu Seçiniz:\nKolay\nNormal\nZor");
            string secim = Console.ReadLine().ToLower();
            if (secim == "kolay")
            {
                Console.WriteLine("Kolay modunu seçtiniz"); Console.WriteLine("Sayıyı tahmin ediniz");
            }
            else if (secim == "normal")
            {
                Console.WriteLine("normal modunu seçtiniz"); Console.WriteLine("Sayıyı tahmin ediniz");
            }
            else if (secim == "zor")
            {
                Console.WriteLine("zor seçtiniz"); Console.WriteLine("Sayıyı tahmin ediniz");
            }
            else
            {
                Console.WriteLine("kolay,normal,zor seçmelisiniz!");
            }
            if (secim == "kolay")
            {
                Random rnd = new Random();
                int hedef = rnd.Next(10);
                for (int i = 10; i <= 10; i--)
                {
                    Console.WriteLine("Kalan hakkınız:");
                    Console.WriteLine(i);
                    int tahmin = int.Parse(Console.ReadLine());
                    if (tahmin == hedef)
                    {
                        Console.WriteLine("Tebrikler kazandınız!\nHerhangi bir tuşa basarak çıkabilirsiniz.");
                        break;
                    }
                    else if (i == 0 && tahmin != hedef)
                    {
                        Console.WriteLine("Oyunu kaybettiniz lütfen tekrar başlatınız!");
                        break;
                    }
                }
            }
            if (secim == "normal")
            {
                Random rnd = new Random();
                int hedef = rnd.Next(25);
                for (int i = 5; i <= 5; i--)
                {
                    Console.WriteLine("Kalan Hakkınız");
                    Console.WriteLine(i);
                    int tahmin = int.Parse(Console.ReadLine());
                    Console.WriteLine(tahmin == hedef ? "Tahmininiz doğru!" : "Tekrar deneyiniz!");
                    if (tahmin == hedef)
                    {
                        Console.WriteLine("Tebrikler kazandınız!\nHerhangi bir tuşa basarak çıkabilirsiniz.");
                        break;
                    }
                    else if (i == 0 && tahmin != hedef)
                    {
                        Console.WriteLine("Oyunu kaybettiniz lütfen tekrar başlatınız!");
                        break;
                    }
                }
            }
            if (secim == "zor")
            {
                Random rnd = new Random();
                int hedef = rnd.Next(50);
                for (int i = 3; i < 4; i--)
                {
                    Console.WriteLine("Kalan Hakkınız");
                    Console.WriteLine(i);
                    int tahmin = int.Parse(Console.ReadLine());
                    if (tahmin == hedef)
                    {
                        Console.WriteLine("Tebrikler kazandınız!\nHerhangi bir tuşa basarak çıkabilirsiniz.");
                        break;
                    }
                    else if (i == 0 && tahmin != hedef)
                    {
                        Console.WriteLine("Oyunu kaybettiniz lütfen tekrar başlatınız!");
                        break;
                    }

                }
            }
            Console.ReadKey();
        }
    }
    
}
