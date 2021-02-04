using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
        
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Ekleniyor" + " Id :" + musteri.Id + " Adı: " + musteri.Ad + " Soyadı: " + musteri.Soyad + " Yaşı: " + musteri.Yaşı + " Yaşadığı Şehir:" + musteri.Şehir);

        }
        public void Musterilistele (Musteri musteri)
        {
            Console.WriteLine("Müşteri Listeleniyor" +" Id :"+ musteri.Id+" Adı: "+ musteri.Ad+" Soyadı: "+musteri.Soyad+" Yaşı: "+ musteri.Yaşı + " Yaşadığı Şehir:" +musteri.Şehir);
        }
        public void Musterisilme (Musteri musteri)
        {
            Console.WriteLine("Müşteri Siliniyor" + " Id :" + musteri.Id + " Adı: " + musteri.Ad + " Soyadı: " + musteri.Soyad + " Yaşı: " + musteri.Yaşı + " Yaşadığı Şehir:" + musteri.Şehir);
        }
    }
}
