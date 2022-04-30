using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    class Abstraction
    {

        class Company
        {
            public void AllDepartment()
            {
                Console.WriteLine("all use to perpetise");
            }
        }
        class Employees : Company
        {
            public void AllDepartment()
            {
                Console.WriteLine("use to employees");
            }
        }
        class Data
        {
            public void AllDepartment()
            {
                Console.WriteLine("data all use");
            }
        }

        abstract class Animal
        {
            public abstract void AnimalSound();
            public void Sleep()
            {
                Console.WriteLine("hi abstract class");
            }

            class Base : Animal
            {
                public override void AnimalSound()
                {
                    Console.WriteLine("override method");
                }
            }
        }
    }
}
