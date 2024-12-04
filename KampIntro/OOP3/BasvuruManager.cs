using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager ,IloggerService ıloggerService)
        {
            krediManager.Hesapla();
            ıloggerService.log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var item in krediler)
            {
                item.Bilgilendir();
            }
        }
    }
}
