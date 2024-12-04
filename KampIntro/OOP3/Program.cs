// See https://aka.ms/new-console-template for more information
using OOP3;

BasvuruManager basvuruManager = new BasvuruManager();

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

//basvuruManager.BasvuruYap(ihtiyacKrediManager);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager ,konutKrediManager};

basvuruManager.KrediOnBilgilendirmesiYap(krediler);