using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Başarıyla Eklendi" + ":" + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı: " + musteri.Adi + " Müşteri Soyadı: " + musteri.Soyadi);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Başarıyla Silindi" + ":" + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
