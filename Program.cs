using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Alper";
            musteri1.Soyadi = "ÇETİN";
            musteri1.Bakiye = 1000;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Şehra";
            musteri2.Soyadi = "ÇETİN";
            musteri2.Bakiye = 10000;

            Musteri musteri3 = new Musteri();

            musteri3.Id = 1;
            musteri3.Adi = "Hatice";
            musteri3.Soyadi = "ÇETİN";
            musteri3.Bakiye = 100000;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Musteri[] müsteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listeleme(müsteriler);

            musteriManager.Sil(musteri1);
        }
    }
}

