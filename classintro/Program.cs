using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "merve";
            int yas = 26;
            Kurs kurs1 = new Kurs();
            kurs1.kursAdı = "c sharp";
            kurs1.kursEgitmeni = "merve";
            kurs1.kursİzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdı = "c ++";
            kurs2.kursEgitmeni = "tokat";
            kurs2.kursİzlenmeOranı = 55;

            Console.WriteLine(kurs1.kursİzlenmeOranı + " "+kurs1.kursEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdı+":"+kurs.kursİzlenmeOranı);
            }
        }
    }
    class Kurs
    {
        public string kursAdı { get; set; }
        public string kursEgitmeni { get; set; }
        public int kursİzlenmeOranı { get; set; }
    }
}
