using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursGün2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] kurslar = new String[] { "kurs1", "kurs2", "kurs3" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for dongusu bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
