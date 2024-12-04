using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService
{
    internal class GamerManager
    {
        private List<Gamer> gamerList;
        public GamerManager() {
            
            gamerList = new List<Gamer>();
        }
        public void add(Gamer gamer)
        {
            GamerCheck gamerCheck = new GamerCheck();
            if (gamerCheck.check(gamer))
            {
                gamerList.Add(gamer);
            }


        }
        public void remove(Gamer gamer) 
        {
            gamerList.Remove(gamer);
        }
        public void update(Gamer gamer) 
        {
           
        }
        public void showGamers()
        {
            foreach (var item in gamerList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
