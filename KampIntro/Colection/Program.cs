// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> isimler = new List<string> { "Engin","Murat","Kerem","Halil"};
isimler.Add("İlker");
foreach (string s in isimler)
{
    Console.WriteLine(s);
}