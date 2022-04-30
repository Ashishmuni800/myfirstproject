using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    class Constructors
    {
        public string name;
        public int age;
        public int roll;
        public int speed;

        public Constructors(string name, int age, int roll)
        {
            this.name = name;
            this.age = age;
            this.roll = roll;
        }
        public Constructors(string name, int age, int roll, int speed)
        {
            this.name = name;
            this.age = age;
            this.roll = roll;
            this.speed = speed;
        }
        public void getName()
        {
            Console.WriteLine("your name is : {0}", name);
        }
        public void getAge()
        {
            Console.WriteLine("your age is : {0}", age);
        }
        public void getRoll()
        {
            Console.WriteLine("your roll number is : {0}", roll);
        }
        public void getSpeed()
        {
            Console.WriteLine("speed is : {0}", speed);
        }
    }
}
