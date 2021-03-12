using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Erik";
            urun3.Fiyati = 150;
            urun3.Sehir = "Elazığ";
            urun3.Aciklama = "Papaz eriği";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Sehir);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-----------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);


        }
    }
}
