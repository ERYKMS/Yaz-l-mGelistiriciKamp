using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi eklenen müşteri : "+musteri.Name);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşter silindi silinen müşteri: " + musteri.Name);
        }
        public void listele(Musteri[] musteri)
        {
            foreach (Musteri m in musteri) { Console.WriteLine(m.Name); }
        }

    }
}
