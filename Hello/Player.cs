using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string Name = "Nilasnhu" ;
        private int health = 72;
         
        public int getHealth()
        {
            return health;
        }
        public void sethealth(int h)
        {
            health = h;
        }
         
    }
}
 