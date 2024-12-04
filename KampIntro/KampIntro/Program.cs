// See https://aka.ms/new-console-template for more information
using KampIntro;
using System.ComponentModel;

Console.WriteLine("Hello, World!");
int number = 5;

int numberOne = number > 15 ? 15 : 12;

Console.WriteLine(numberOne);

int[] numberArray = { 2, 3, 4, 5 };

for (int i =0; i < numberArray.Length; i++){

    Console.WriteLine(numberArray[i]);

}
Eray eray = new Eray();
eray.MyProperty = 5;

Console.WriteLine(eray.MyProperty);

Product urun1 = new Product();
urun1.Adi = "Elma"; 
urun1.Fiyati = 1;
urun1.Acıklama = "Yeşil Ekşi";

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 2;
urun2.Acıklama = "Kırmızı Sulu";

Product[] urunler = new Product[] {urun1,urun2};

foreach (Product urun in urunler)
{
    Console.WriteLine
        (urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Acıklama);
    Console.WriteLine("-------------------");
}

SepetManager sep = new SepetManager();
sep.Ekle(urun1);
sep.Ekle(urun2);

class Eray
{
    public int MyProperty { get; set; }
    
}