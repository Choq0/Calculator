using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hesap Makinesi");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("0. Çıkış");
                Console.Write("Seçiminizi yapın (0-4): ");

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 0)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }

                Console.Write("Birinci sayıyı girin: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;

                switch (secim)
                {
                    case 1:
                        sonuc = sayi1 + sayi2;
                        break;
                    case 2:
                        sonuc = sayi1 - sayi2;
                        break;
                    case 3:
                        sonuc = sayi1 * sayi2;
                        break;
                    case 4:
                        if (sayi2 != 0)
                            sonuc = sayi1 / sayi2;
                        else
                            Console.WriteLine("Hata: Bölme işlemi için ikinci sayı 0 olamaz.");
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                        break;
                }

                Console.WriteLine("Sonuç: " + sonuc);
            }
        }
    }
}
