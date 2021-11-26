using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_MetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  adlı müşteri eklendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "adlı müşteri silindi..");
        }

        public void MusteriListele( Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
            }
        }
    }
}
