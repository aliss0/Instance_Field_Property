using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_Field_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //Class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            //    }  
            //      // Metot Komutları
            //    }
            //}


            // Erişim Belirliyicileri
            //public
            //private
            //internal
            //protected

            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ali";
            calisan1.soyad = "Uygun ";
            calisan1.No = 23425634;
            calisan1.Departman = "Bilişim ";

            calisan1.CalısanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Çağrı ";
            calisan2.soyad = "Dönmez";
            calisan2.No = 6543210;
            calisan2.Departman = "Yönetim";

            calisan2.CalısanBilgileri();
            Console.ReadLine();
        }
             class Calisan
        {
            public string ad;

            public string soyad;

            public int No;

            public string Departman;


            public void CalısanBilgileri()
            {
                Console.WriteLine();
                Console.WriteLine("Çalışanın Adı: {0}", ad);
                Console.WriteLine("Çalışanın Soyadı: {0}", soyad);
                Console.WriteLine("Çalışanın Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
            }
            
        }
       

    }
}

