using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : " + musteri.Id);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri listelendi : " + musteri.Id);
        }
    }
}
