using System;

namespace Class_MetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "aslıhan";
            musteri1.Soyad = "kandaz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "tolga ";
            musteri2.Soyad = "tuncel";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "halime ";
            musteri3.Soyad = "kandaz";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);



        }

    }
}
