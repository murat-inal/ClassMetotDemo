using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 123121;
            musteri1.Ad = "Murat";
            musteri1.Soyad = "İnal";
            musteri1.Email = "muratinal@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 123122;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Veli";
            musteri2.Email = "aliveli@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 123123;
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Fatma";
            musteri3.Email = "aysefatma@gmail.com";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

        }
    }
}
