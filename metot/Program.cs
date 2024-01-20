using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "Elma";
            double fiyatı = 15;
            string açiklama = "amasya elma";

            string urunAdı2 = "Armut"
            double fiyatı2 = 10;
            string açiklama2 = "Kış MEyvesi";

            Product urun1 = new Product();//product sınıfından degişken oluşturduk.
            urun1.Adi = "elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "yeşil elma";

            Product urun2 = new Product();
            urun2.Adi = "kiraz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "yerli kiraz";

            Product[] urunler = new Product[] { urun1, urun2 };//product sınıfından dizi olusturduk.
            foreach (Product a in urunler)//product yerine var yazarsak otomatik product sınıfından döndürür.
            {
                Console.WriteLine(a.Adi + " ," + a.Fiyati + " ," + a.Aciklama + " ");
            }

        }
    }
}
