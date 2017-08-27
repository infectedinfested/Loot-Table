using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Table
{
    class Roller
    {
        public int roll(int counter, int die)
        {
            int result = 0;
            Random rnd = new Random();
            for (int i = 0; i < counter; i++)
            {
                result = result + rnd.Next(1, die+1);
            }
            return result;
        }
    }
}
