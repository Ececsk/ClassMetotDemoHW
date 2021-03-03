using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    
    class MusteriManager
    {
        Musteri[] customerList = new Musteri[] { };
        public void Ekle(Musteri customer) {
            Console.WriteLine("Müşteri Eklendi : " + customer.Id + " " + customer.Ad + " " + customer.Soyad + " "+customer.Yas+" " + customer.Cinsiyet);
            Console.WriteLine(customer.Ad+" "+customer.Soyad+" "+customer.Yas+" "+customer.Cinsiyet);
            Console.WriteLine("\n--------------------------");
        }
        public void Sil(Musteri customer)
        {

            Console.WriteLine(customer.Id + " " + customer.Ad + " " + customer.Soyad +" adlı müşteri Silindi.");
            Console.WriteLine("ID:{0} nolu Müşteri silindi", customer.Id);
            Console.WriteLine("\n--------------------------");
            
        }
        public void Listele(Musteri[] customers) {
            Console.WriteLine("Müşteri Listesi:");
            foreach (var c in customers)
            {
                Console.WriteLine("\nId: "+c.Id+" Ad: "+c.Ad+" Soyad: "+c.Soyad+" Yaş: "+c.Yas+" Cinsiyet: "+c.Cinsiyet);
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nMüşteriler Listelendi\n\n");
        }
    }
}
