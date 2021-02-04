using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Huriye";
            musteri1.Soyad = "Kengeroglu";
            musteri1.Yaşı = 23;
            musteri1.Şehir = "Kahramanmaraş";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Serhat";
            musteri2.Soyad = "Havadan";
            musteri2.Yaşı = 19;
            musteri2.Şehir = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Asuman";
            musteri3.Soyad = "Duman";
            musteri3.Yaşı = 20;
            musteri3.Şehir = "Kütahya";


            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "M Yiğit";
            musteri4.Soyad = "Karademir";
            musteri4.Yaşı = 20;
            musteri4.Şehir = "Muğla";

            MusteriManager MusteriManager1 = new MusteriManager();
            
            MusteriManager1.Musterilistele(musteri1);
            MusteriManager1.Musterilistele(musteri2);
            Console.WriteLine("MÜŞTERİ LİSTESİ");
            Console.WriteLine("---------------------");

            MusteriManager MusteriManager2 = new MusteriManager();
            
            MusteriManager2.MusteriEkle(musteri3);
            MusteriManager2.MusteriEkle(musteri4);
            Console.WriteLine("EKLENEN MÜŞTERİLER");

            Console.WriteLine("-------------------------");

           
            MusteriManager MusteriManager3 = new MusteriManager();
            MusteriManager3.Musterisilme(musteri2);
            Console.WriteLine("SİLİNEN  MÜŞTERİLER");
            Console.WriteLine("-----------------------");


            
            

           
            
         
            
            


        }
    }
}
