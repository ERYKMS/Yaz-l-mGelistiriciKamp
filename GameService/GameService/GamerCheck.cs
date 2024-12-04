using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService
{
    internal class GamerCheck
    {
        public bool check(Gamer gamer)
        {
            if (gamer.Name != null) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
