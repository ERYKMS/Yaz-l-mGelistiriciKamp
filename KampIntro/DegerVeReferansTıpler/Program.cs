// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;
MusteriManager manager = new MusteriManager();

Console.WriteLine("Hello, World!");
Musteri musteri1 = new Musteri();
musteri1.Name = "Eray";

Musteri musteri2 = new Musteri();
musteri2.Name = "Ebrar";

Musteri[] musteriler= new Musteri[] { musteri1, musteri2 };

manager.Ekle(musteri1);
manager.listele(musteriler);
