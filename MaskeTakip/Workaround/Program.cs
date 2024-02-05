// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {

        static void Main(string[] args)
        {
            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            SelamVer(isim:"Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
         


            for (int i = 0; i <ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;


            Person person2 = new Person();
            person2.FirstName = "Murat";


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc);
            return sonuc;
        }

    }
}
    

  