using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    internal class Car
    {
        /*
               int num;
               int space;
               for (int i = 1; i < 5; i++)
               {
                   for (space = 1; space <= (5 - i); space++)
                   {
                       Console.Write("* ");
                   }

                   //for (int j = 1; j <= i; j++)
                   {
                       //Console.Write(j);
                   }

                   //for (int k = (i - 1); k >= 1; k--)
                   {
                       //Console.Write(k);
                   }

                   Console.WriteLine();

               }

               /*
               int s = 0;
               for(int i=1; i<5; i++)
               {
                   Console.WriteLine(i);
                   s = s + i;
               }
               Console.WriteLine(s);
               */


        //Console.WriteLine("Welcome to choice of the three numbers please Enter now : ");

        //Console.WriteLine("Enter your first number");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter your second number");
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter your third number");
        //int c = int.Parse(Console.ReadLine());
        //float sum = (a + b + c)/3;
        //Console.WriteLine("average of the three number is : " + sum);


        /*
       Console.WriteLine("Enter your pin");
        int bal = 2000;
        int pin = int.Parse(Console.ReadLine());
        if (pin == 1234)
        {
            Console.WriteLine("Enter your choice :\n balence ckeck : 1\n Widrow money : 2"); 
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("balence :" +bal);
                    break;

                case 2:
                    Console.WriteLine("enter your amount");
                    int debit = int.Parse(Console.ReadLine());
                    int current = bal - debit;
                    Console.WriteLine("bal:-" + current);
                    break;

                default:
                    Console.WriteLine("invaled choice");
                    break;
            }
        }
        else
        {
            Console.WriteLine("invaled pin");
        }
        */

        //string[] arr = { "asalm", "rohan", "ashish" };
        //int[] num = { 5, 1, 4, 2, 3 };
        //Console.WriteLine(arr.Length);
        //for(int i=0; i<arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //Array.Sort(num);
        //foreach(int i in num)
        //{
        //    Console.WriteLine(i);
        //}

        //Console.WriteLine(num.Length);
        //Console.WriteLine(num.Max());
        //Console.WriteLine(num.Sum());

        //continue statement - while loop
        //int i= 0;
        //while (i < 10)
        //{
        //    if (i == 4)
        //    {
        //        i++;
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //    i++;
        //}

        //break statement - while loop
        //int i = 0;
        //while (i < 10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //    if (i == 5)
        //    {
        //        break;
        //    }
        //}

        //break statement - for loop
        //for(int i=0; i<10; i++)
        //{
        //    if (i == 4)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}

        //continue statement - for loop
        //for(int i=0; i<10; i++)
        //{
        //    if (i == 5)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //for(int i=1; i<=5; i++)
        //{
        //    for(int j=1; j<=i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine("\n");
        //}

        //string[] arr = { "ab", "bc", "cd", "ad" };
        //int[] num2 = {2, 5, 4, 3, 8};
        //Array.Reverse(arr);
        //Array.Reverse(num2);
        //Console.WriteLine(num2);

        //Greate(" ashish");
        //Greate(" asalm");


        //float avg = Average(4, 6, 8);
        //Console.WriteLine(avg);

        //float avg2 = Average(4, 8);

        //Player rohan = new Player();
        //Console.WriteLine(rohan.getHealth());
        //rohan.setHealth(69);
        //Console.WriteLine(rohan.getHealth());

        /*
        int i, j, count = 1, num;
        Console.WriteLine("enter no. of rows");
        num = int.Parse(Console.ReadLine());
        count = num - 1;
        for(j=1; j<=num; j++)
        {
            for(i=1; i<=count; i++)
               Console.Write(" ");
            count--;
            for(i=1; i<=2 * j-1; i++)
               Console.WriteLine(" *");
        }
        count = 1;
        for(j=1; j<=num-1; j++)
        {
            for (i = 1; i <= count; i++)
                Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (num - j) - 1; i++) ;
            Console.WriteLine(" *");
        }*/

        //string[] arr = { "ashish", "asalm", "devendra", "rohan" };
        //foreach(string i in arr)
        //{
        //    Console.WriteLine(i);
        //}

        /*
        int n;
        Console.WriteLine("Enter a number : ");
        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("Entered is a even number : "+n);
        }
        else
        {
            Console.WriteLine("odd : "+n);
        }


        int i, count, f1 = 0, f2 = 1, f3 = 0;
        Console.Write("Enter the limit : ");
        count = int.Parse(Console.ReadLine());
        for(i=0; i<=count; i++)
        {
            f3 = f1 + f2;
            Console.WriteLine(f3);
            f1 = f2;
            f2 = f3;
        }


        int num, n;
        Console.WriteLine("Enter the number");
        num = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = num; i > 0; i--)
        {
            result *= i;
            Console.WriteLine(result);
        }
        */





        /*
        string username;
        Console.WriteLine("Enter the name");
        Again:
        username = Console.ReadLine();
        if (username == "ashish")
        {
            Console.WriteLine("my name is " + username);
        }
        else
        {
            Console.WriteLine("invalid name");
            goto Again;

        }

        //login page
        string username;
            string password;
            Console.WriteLine("Enter correct username and password combo to continue");
            int count = 0;
            while(count < 3)
            {
                Console.WriteLine("Enter username: ");
                username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();

                if (password == "1234" && username == "ashish")
                {
                    Console.WriteLine("You Login");
                    break;

                }
                else
                {
                    Console.WriteLine("Try again.");
                    count += 1;
                }

            }
        */

        //string[] arr = { "ashish", "devendra", "rohan", "shashi" };

        //List<string> arrList = arr.ToList();
        //foreach(string i in arrList)
        //{
        //    Console.WriteLine(i);
        //}
    }
}
