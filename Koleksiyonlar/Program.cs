// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
Console.WriteLine("Hello, World!");
string[] isimler = new string[] { "a1", "a2", "a300" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);//arayler sabit ekstra eklenemez



List<string> isimler2 = new List<string> { "aa","ed","dd"};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
isimler2.Add("engin");
Console.WriteLine(isimler2[3]);
Console.WriteLine(isimler2[0]);