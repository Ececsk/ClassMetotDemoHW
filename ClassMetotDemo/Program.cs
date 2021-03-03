using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {   //Yazılım Geliştirici Yetiştirme Kampı - 3.gün - Ödev3.
            //Projeniz şunu yapacak
            //Bir bankada müşteri takibi yapmak istiyorsunuz.
            //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Ak";
            musteri1.Yas = 41;
            musteri1.Cinsiyet = 'E';

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ayşe";
            musteri2.Soyad = "Yılmaz";
            musteri2.Yas = 38;
            musteri2.Cinsiyet = 'K';

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Merve";
            musteri3.Soyad = "Bilge";
            musteri3.Yas =25;
            musteri3.Cinsiyet = 'K';

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad ="Deniz";
            musteri4.Soyad = "Can";
            musteri4.Yas = 23;
            musteri4.Cinsiyet = 'E';

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri3);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
