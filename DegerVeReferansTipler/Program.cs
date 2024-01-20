// See https://aka.ms/new-console-template for more information
using System;
namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int sayi1 = 10;
            int sayi2 = 33;
            sayi1 = sayi2;
            sayi2 = 66;
            Console.WriteLine(sayi1);//cevap 33 stack sadece sayı degeri degişkene aktarılır
            int[] sayilar1 = new int[] { 22, 6, 5 };
            int[] sayilar2 = new int[] { 0, 8, 77 };
            sayilar1 = sayilar2;
            sayilar2[0] = 13;
            foreach (int x in sayilar1)
            {
                Console.WriteLine(x) ;//cevap  13,8,77 heap degişkenin yolu aktarılır oyuzden degişim var
            }
        }
    }
}
