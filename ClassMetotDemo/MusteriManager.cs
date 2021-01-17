using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleniyor.. {0} {1}\n{0} {1} Eklendi !!\n", musteri.Ad, musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Siliniyor.. {0} {1}\n{0} {1} Silindi !!\n", musteri.Ad, musteri.Soyad);
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("\n-----------------Listeleme Operasyonu----------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("ID : {0}\nAd : {1}\nSoyad : {2}\nE-Mail : {3}", musteri.ID, musteri.Ad, musteri.Soyad,musteri.Email);
                Console.WriteLine("\n----------------------------------------------------------\n");
            }
        }
    }
}
