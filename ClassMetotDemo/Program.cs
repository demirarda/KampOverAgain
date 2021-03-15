using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Arda";
            musteri1.SoyAd = "Demir";
            musteri1.TcNo = "1111111111111";
            musteri1.Sehir = "Elazığ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "İzel";
            musteri2.SoyAd = "Çakır";
            musteri2.TcNo = "111111111111115";
            musteri2.Sehir = "Elazığ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.SoyAd);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine("----------------");

                
                
                
            }

            Console.WriteLine("------------------------------------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri1);

            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteri2);
        }
    }
}
