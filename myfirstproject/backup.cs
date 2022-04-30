using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    class backup
    {
        /*
        Program obj = new Program("ashish", 23, 12);
        obj.getName();
            obj.getAge();
            obj.getRoll();

            Console.WriteLine("------------------");
            Program obj1 = new Program("rohan", 22, 20, 40);
        obj.getName();
            obj.getAge();
            obj.getRoll();
            obj1.getSpeed();

            


            //Program obj = new Program();
            //obj.Counting();
            //Console.ReadLine();

            //Player tommy = new Player("ashish", 46);
            //tommy.getName();
            //tommy.getHealth1();
            //Player obj = new Player();

            //Console.WriteLine(tommy.name);
            //Console.WriteLine(tommy.Health);
            //tommy.setHealth(44); 
            //Console.WriteLine(tommy.Health);
            //Console.WriteLine(tommy.getHealth());*/

        //q1.
        //Console.WriteLine("enter your name");
        //    string name = Console.ReadLine();
        //    if (name.Length == 0)
        //        return;
        //    Console.Write(char.ToUpper(name[0]));
        //    for (int i = 1; i<name.Length - 1; i++)
        //        if (name[i] == ' ')
        //            Console.WriteLine("." + char.ToUpper(name[i + 1]) + " sharma");

            //Q2.


            ////Q3.
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();

            //int wordCount = 0;

            //for (int i = 0; i < name.Length - 1; i++)
            //{
            //    //Counts all the spaces present in the string  
            //    //It doesn't include the first space as it won't be considered as a word  
            //    if (name[i] == ' ' && Char.IsLetter(name[i + 1]) && (i > 0))
            //    {
            //        wordCount++;
            //    }
            //}
            ////To count the last word present in the string, increment wordCount by 1  
            //wordCount++;

            ////Displays the total number of words present in the given string  
            //Console.WriteLine("Total number of words in the given string: " + wordCount);

            //Console.Write("Enter your string : ");
            //string str = Console.ReadLine();

            //int l = 0;
            //int wrd = 1;

            ///* loop till end of string */
            //while (l <= str.Length - 1)
            //{
            //    /* check whether the current character is white space or new line or tab character*/
            //    if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            //    {
            //        wrd++;
            //    }

            //    l++;
            //}

            //Console.Write("Total number of words in the string is : {0}\n", wrd);

            //Q4.
            //Console.WriteLine("Enter string");
            //String str = Console.ReadLine();
            //int[] freq = new int[str.Length];

            ////Converts given string into character array  
            //char[] string1 = str.ToCharArray();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    freq[i] = 1;
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (string1[i] == string1[j])
            //        {
            //            freq[i]++;

            //            //Set string1[j] to 0 to avoid printing visited character  
            //            string1[j] = '0';
            //        }
            //    }
            //}

            ////Displays the each character and their corresponding frequency  
            //Console.WriteLine("Characters and their corresponding frequencies");
            //for (int i = 0; i < freq.Length; i++)
            //{
            //    if (string1[i] != ' ' && string1[i] != '0')
            //        Console.WriteLine(string1[i] + "-" + freq[i]);
            //}

            //Console.WriteLine("Input the string");
            //string str = Console.ReadLine();

            //var FreQ = from x in str
            //           group x by x into y
            //           select y;
            //Console.Write("The frequency of the characters are :\n");
            //foreach (var ArrEle in FreQ)
            //{
            //    Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count());
            //}

            //Q5.
            //Console.WriteLine("Enter specific strings");
            //string str = Console.ReadLine();
            ////string str = "@ashish @muni.";
            //List<char> charsToRemove = new List<char>() { '@', '_', ',', '.', '~' };

            //str = str.Filter(charsToRemove);
            //Console.WriteLine(str);

            //Console.WriteLine("enter your string");
            //string myString = Console.ReadLine();
            //string newString = myString.Replace("@", string.Empty);

            //Console.WriteLine(newString);
    }
}
