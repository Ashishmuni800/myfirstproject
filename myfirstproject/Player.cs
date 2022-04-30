using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    internal class Player
    {
        public string name = "ashish";
        public int health = 59;
        //private int Health = 59;
        static int speed = 20;

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int h)
        {
            health = h;
        }

        /*
        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;

        }
        public void getName()
        {
            Console.WriteLine("name is : {0}",name);
        }
        public void getHealth1()
        {
            Console.WriteLine("health is : {0}", health);
        }
        */

    }
}
