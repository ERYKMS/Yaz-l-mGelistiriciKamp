using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class KonutKrediManager : IKrediManager
    {
        public void Bilgilendir()
        {
            Console.WriteLine("Konut kredisi 234521");
        }

        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            throw new NotImplementedException();
        }
    }
}
