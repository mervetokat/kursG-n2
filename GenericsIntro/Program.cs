// See https://aka.ms/new-console-template for more information
using GenericsIntro;

Console.WriteLine("Hello, World!");
MyList<string> isimler = new MyList<string>();
isimler.Add("ela");
Console.WriteLine(isimler.Lenght);
isimler.Add("merve");
Console.WriteLine(isimler.Lenght);
foreach (var item in isimler.Items)
{
    Console.WriteLine(item);
}