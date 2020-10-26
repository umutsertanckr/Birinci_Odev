using System;

namespace Birinci_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPicker();
            Console.WriteLine("\n\n Çıkmak için Enter'a basınız.");
            Console.ReadLine();
        }

        private static void DisplayPicker()
        {
            DisplayTitle("Uygulama Seçiniz");
            try
            {
                var a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: IkiSayidanBuyukOlan(); break;
                    case 2: CarpimTablosu(); break;
                    case 3: VizeFinalOrt(); break;
                    case 4: KelimeUzunlugu(); break;
                    case 5: CarpmaIslemi(); break;
                    default: Console.WriteLine("Bir uygulama numarası seçin: ( 1-2-3-4-5 )\n"); break;
                }

                if (a > 0 && a <= 5) DisplayPicker();
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapın...");
            }

        }

        private static void IkiSayidanBuyukOlan()
        {
            DisplayTitle("İki sayıdan Büyük Olan Sayıyı Gösteren Uygulama");
            try
            {
                // İki sayıdan büyük olan sayıyı gösteren program.
                int x, y;
                Console.WriteLine("1. Sayıyı Giriniz:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Giriniz:");
                y = Convert.ToInt32(Console.ReadLine());
                if (x > y)
                {
                    Console.Write("Büyük Oan Sayı: " + x);
                }
                else
                {
                    Console.Write("Büyük Olan Sayı: " + y);
                }
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapın...");

            }
        }

        private static void CarpimTablosu()
        {
            DisplayTitle("Çarpım Tablosu");
            // Çarpım tablosunu gösteren program.
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    Console.Write("{0}*{1}={2}    ", b, a, (b * a));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void VizeFinalOrt()
        {
            DisplayTitle("Vize-Final Not Ortalamasını Bulan Program");
            try
            {
                // Vize-Final notu ortalaması hesaplama programı.
                int vize, final, ortalama;
                Console.Write("Vize Notunuz: ");
                vize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Final Notunuz: ");
                final = Convert.ToInt32(Console.ReadLine());
                ortalama = Convert.ToInt32(vize * 0.4 + final * 0.6);
                Console.WriteLine();
                Console.WriteLine("Ortalamanız = {0}", ortalama);
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapın...");

            }
        }

        private static void KelimeUzunlugu()
        {
            DisplayTitle("Kelime Uzunluğu Bulan Metod");
            // Girilen kelimenin uzunluğunu bulma programı.
            string a;
            int b;
            Console.Write("Kelime Uzunuluğunu Bulma\n");
            Console.Write("\nKelimeyi Giriniz: ");
            a = Console.ReadLine();
            b = a.Length;
            Console.WriteLine("\nKelimenin Uzunluğu: " + b);
            Console.ReadKey();
        }

        private static void CarpmaIslemi()
        {
            DisplayTitle("Çarpma işlemini toplama kullanarak yapan program");
            try
            {
                // Çarpmayı toplama kullanarak yapan program.
                int a, b, c = 0, i;
                Console.WriteLine("Çarpmayı Toplayarak Yapan Program\n");
                Console.Write("1. Sayıyı Giriniz: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n2. Sayıyı Giriniz: ");
                b = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= b; i++)
                {
                    c += a;
                }
                Console.WriteLine("\n" + c);
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapın...");

            }
        }

        private static void DisplayTitle(string title)
        {
            Console.WriteLine($"------------------------\n{title}:");
        }
    }
}