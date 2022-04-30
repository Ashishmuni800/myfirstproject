using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using static myfirstproject.Polymorphysm;
using static myfirstproject.Interface;
using static myfirstproject.Constructors;
using static myfirstproject.Abstraction;
using static myfirstproject.Inheritance;

namespace myfirstproject
{
    abstract class Catcutate
    {
        public abstract void Add();
        public void Great()
        {
            Console.WriteLine("Good morning");
        }
    }
    class ShowCal : Catcutate
    {
        public override void Add()
        {
            int a = 2;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);
        }
    }
    public static class Extensions
    {
        public static string Filter(this string str, List<char> charsToRemove)
        {
            foreach (char c in charsToRemove)
            {
                str = str.Replace(c.ToString(), String.Empty);
            }

            return str;
        }
    }
    class Person
    {
        private string Name;
        private int Age;

        public void setName(string name)
        {
            if(string.IsNullOrEmpty(name)==true){
                Console.WriteLine("fill your name");
            }
            else
            {
                this.Name = name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine(this.Name);
            }
            
        }

        public void setAge(int age)
        {
            if (age > 0)
            {
                this.Age = age;
            }
            else
            {
                Console.WriteLine("age is not require");
            }
        }
        public void getAge()
        {
            if (Age > 0)
            {
            Console.WriteLine(this.Age);

            }
            else
            {

            }
        }
    }
  
    class Great
    {
        public virtual void MyGreat()
        {
            Console.WriteLine("Greating All");
        }
    }
    class GreatM : Great
    {
        public override void MyGreat()
        {
            Console.WriteLine(" good Morning");
        }
    }
    class GreatE : Great
    {
        public override void MyGreat()
        {
            Console.WriteLine(" good evening");
        }
    }
    class GreatN : Great
    {
        public override void MyGreat()
        {
            Console.WriteLine("Good Morning");
        }
    }

    class Details
    {
        public string name;
        public int age;
        public Details(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GetName()
        {
            Console.WriteLine(name);
        }
        public Details(Details e)
        {
            this.name = e.name;
            this.age = e.age;
        }
    }

    public delegate void Age(int age);
    internal class Program
    {
        
        /*
        int num = 1;
        void Counting()
        {
            if (num == 11)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            Counting();
        }
        */
        class Employee
        {
            private int[] age = new int[3];

            public int this[int index]
            {
                set
                {
                    if (index >= 0 && index <age.Length)
                    {
                        if (value > 0)
                        {
                            age[index] = value;
                        }
                        else
                        {
                            Console.WriteLine("invalide age");
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalide index");
                    }
                }
                get
                {
                    return age[index];
                }
                
            }
        }
        public static void ShowArray<s>(s[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("access denied");
            }
            else
            {
                Console.WriteLine("access granted");
            }
        }

        //Q1.
        //public static void Print()
        //{
        //    Console.WriteLine("Enter your name");
        //    string name= Console.ReadLine();
        //    if (name.Length == 0)
        //        return;
        //    Console.Write(Char.ToUpper(name[0]));
        //    for (int i = 1; i < name.Length - 1; i++)
        //        if (name[i] == ' ')
        //            Console.WriteLine("." + char.ToUpper(name[i + 1]) +" Sharma");

        //}

        public static int CountChar(char[] chrr, char ch)
        {
            int Count = 0;
            for(int i=0; i<chrr.Length; i++)
            {
                if (chrr[i] == ch)
                {
                    Count++;
                }
            }
            return Count;
        }

        private string RandomOtpGenerate(int iOtpLength, string[] AllowCharactors)
        {
            string SOtp = string.Empty;
            string sTempdata = string.Empty;
            Random ramd = new Random();
            for(int i=0; i<iOtpLength; i++)
            {
                sTempdata = AllowCharactors[ramd.Next(0, AllowCharactors.Length)];
                SOtp += sTempdata;
            }
            return SOtp;
        }

        public static void PrintIndexValues(string[] myArr)
        {
            for(int i=0; i<myArr.Length; i++)
            {
                Console.WriteLine("{0}",myArr[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
            //array
            //Q1.
            //int[] arr = new int[10];
            //int[] num = { 5, 7, 8, 9, 3, 5, 1, 4, 6, 7 };
            //Console.WriteLine(num.Sum());


            //int[] a = new int[100];
            //int i, n, sum = 0;


            //Console.WriteLine("Find sum of all elements of array:");

            //Console.WriteLine("Input the number of elements to be stored in the array :");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input {0} elements in the array :", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i < n; i++)
            //{
            //    sum += a[i];
            //}

            //Console.WriteLine("Sum of all elements stored in the array is : {0}", sum);
            //Q2.
            //int i = 0;

            //Console.WriteLine("Even Numbers :");
            //for (i = 1; i < num.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //Console.WriteLine("\nOdd Numbers :");
            //for (i = 1; i < num.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //Q3.
            //string[] myArr = { "ashish", "rohan", "devendra", "asslsm", "vipin", "nikush", "harsh", "ajay", "vivek", "vinod" };
            //PrintIndexValues(myArr);
            //Console.WriteLine("Enter your find name");
            //string f = Console.ReadLine();
            //string value = Array.Find(myArr,
            //           element => element.StartsWith(f,
            //           StringComparison.Ordinal));
            //Console.Write("Element: ");
            //Console.Write("{0}", value);

            ////Q4.
            //int[] arr = { 78, 55, 45, 98, 13, 77, 98,33, 65, 83 };
            //int temp;
            //for (int j = 0; j <= arr.Length - 2; j++)
            //{
            //    for (int i = 0; i <= arr.Length - 2; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Sorted:");
            //foreach (int p in arr)
            //    Console.Write(p + " ");



            //Q1.
            //string[] AllowCharactors = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            //Program Otp = new Program();
            //string gOtp = Otp.RandomOtpGenerate(6, AllowCharactors);
            //Console.WriteLine("Random Otp is : {0}",gOtp);

            //Q2.
            //Console.WriteLine("Enter your Date of birth");
            //string str = Console.ReadLine();
            //DateTime bday = Convert.ToDateTime(str);
            //DateTime today = DateTime.Today;
            //int age = today.Year - bday.Year;
            //if (bday > today.AddYears(-age))
            //    age--;
            //Console.WriteLine(age);


            //string _Inputstr = string.Empty, _Reversestr = string.Empty;
            //_Inputstr = "ashish";
            //for (int i = _Inputstr.Length - 1; i >= 0; i--)
            //{
            //    _Reversestr += _Inputstr[i];
            //}
            //Console.WriteLine("The reverse string is {0}", _Reversestr);

            //Q1.
            //Console.WriteLine("Enter your name");
            //string str = Console.ReadLine();
            ////string str = "";
            //string[] strArr = str.Split(' ');
            //StringBuilder sb = new StringBuilder();
            //for(int i = 0; i < strArr.Length - 1; i++)
            //{
            //    sb.Append(strArr[i].Substring(0, 1).ToUpper());
            //    sb.Append(". ");
            //}
            //sb.Append(strArr[strArr.Length - 1]);
            //Console.WriteLine(sb);

            //Q2.
            //string a = Console.ReadLine();
            //string[] aArr = a.ToUpper().Split(' ');
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < aArr.Length; i++)
            //{
            //    var a1 = aArr[i].ToLower();
            //    string a2 = aArr[i].Replace(aArr[0], a1[0]);
            //    sb.Append(a2 + " ");
            //}
            //Console.WriteLine(sb);

            //Q3.
            //string str = "i am good human";
            //string[] strArr = str.Split(' ');
            //string finder = "am";
            //int count = 0;
            //for(int i=0; i<strArr.Length; i++)
            //{
            //    if (strArr[i].ToLower() == finder.ToLower())
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"{finder}:{count}");

            //Q4.
            //Console.WriteLine("Enter string count");
            //string str = Console.ReadLine();
            //var StrChar = str.ToCharArray();
            //char[] existchar = new char[StrChar.Length];
            //int x = 0;
            //for(int i=0; i<StrChar.Length; i++)
            //{
            //    if(CountChar(existchar, StrChar[i]) == 0)
            //    {
            //        int count = CountChar(StrChar, StrChar[i]);
            //        Console.WriteLine($"{StrChar[i]}={count}");
            //    }
            //    existchar[x] = StrChar[i];
            //    x++;
            //}


            //Age a = new Age(Program.CheckAge);
            //a.Invoke(1);
            //indexer  
            //Employee e = new Employee();
            //e[0] = 5;
            //Console.WriteLine(e[0]);


            //Details d = new Details("ashish",44);
            //d.GetName();
            //Details d1 = new Details(d);
            //d1.GetName();

            //int[] num = { 2, 3, 5, 6 };
            //string[] name = { "ashish", "rohan" };
            //Program.ShowArray(num);
            //Program.ShowArray(name);

            //encapsulation
            //Person obj = new Person();
            //obj.setName("ashish");
            //obj.getName();
            //obj.setAge(23);
            //obj.getAge();


            //interface
            //get g = new get();
            //g.Show();

            /*
            //polymorphysm
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };
            Great obj = new Great();
            Great obj1 = new GreatM();
            Great obj2 = new GreatE();
            Great obj3 = new GreatN();
            obj.MyGreat();
            obj1.MyGreat();
            obj2.MyGreat();
            obj3.MyGreat();
            
            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            
            //abstraction
            Company p = new Company();
            p.AllDepartment();
            Employees e = new Employees();
            e.AllDepartment();
            Data d = new Data();
            d.AllDepartment();*/

            /*
            //Constructors
            Constructors c = new Constructors("ashish",23,10);
            c.getName();
            c.getAge();
            c.getRoll();*/

            //inheritance
            // Create a myCar object
            //Car myCar = new Car();

            //// Call the honk() method (From the Vehicle class) on the myCar object
            //myCar.honk();

            //// Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            //Console.WriteLine(myCar.brand + " " + myCar.modelName);

            //enum
            //Elevel MyE = Elevel.Low;
            //Console.WriteLine(MyE);
            //int num = (int)Elevel.january;
            //Console.WriteLine(num);
            //foreach (string s in Enum.GetNames(typeof(Elevel)))
            //{
            //    Console.WriteLine(s);
            //}

            //Exception handling
            //try
            //{
            //    int[] MyNumber = {2,3,5,7,8};
            //    Console.WriteLine(MyNumber[7]);
            //}
            //catch(Exception)
            //{
            //    string Message = "index not found";
            //    Console.WriteLine(Message);
            //}
            //finally
            //{
            //    Console.WriteLine("try is finished");
            //}

            //file handling
            //string writeText = "ashish";
            //File.WriteAllText("ab.txt", writeText);
            //string readText = File.ReadAllText("ab.txt");
            //Console.WriteLine(readText);

            //ArrayList
            //var arr = new List<int>();
            //arr.Add(4);
            //arr.Add(5);
            //arr.Add(3);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //var Str_Arr = new List<string> { "ashish", "vipin", "ajay" };
            ////Str_Arr.Remove("ashish");
            //foreach (var item in Str_Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //var num = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for(var index=num.Count-1; index>=0; index--)
            //{
            //    if (num[index] % 2 == 1)
            //    {
            //        num.RemoveAt(index);
            //    }
            //}
            //num.ForEach(number => Console.WriteLine(number));


            //int[] iArr = { 2, 4, 5, 6, 8, 2, 3, 1 };
            //Array.Sort(iArr);
            //Array.Reverse(iArr);
            //foreach (int item in iArr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(iArr.Sum());

            Random rd = new Random();
            int n;
            //for(int i = 1; i <= 6; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        n = rd.Next(65, 90);
            //        Console.Write(Convert.ToChar(n)+" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 6; i >= 1; i--)
            //{
            //    for(int j=1; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int z = 6; z >= i; z--)
            //    {
            //        n = rd.Next(65, 90);
            //        //Console.Write(Convert.ToChar(n)+" ");
            //        Console.Write(Convert.ToChar(n));
            //        //Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        n = rd.Next(65, 90);
            //        Console.Write(Convert.ToChar(n) + " ");
            //        //Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 5; i >= 1; i--)
            //{
            //    for(int j = 5; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int z = 1; z <= i; z++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i < 5; i++)
            //{
            //    for(int j = i; j < 5; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int z = 1; z < (i * 2); z++)
            //    {
            //        //n = rd.Next(65, 90);
            //        //Console.Write(Convert.ToChar(n));
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 5; i >= 1; i--)
            //{
            //    for(int j = 5; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int z = 1; z < (i * 2); z++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = i; j < 5; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 1; j <= (2 * i - 1); j++)
            //    {
            //        if(i==5 || j==1 || j == (2 * i - 1)){
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        if(j==1 || j==i || i == 5)
            //        {
            //            n = rd.Next(65, 90);
            //            Console.Write(Convert.ToChar(n));
            //            //Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //var student = new { Id = 987654, Name = "ashish", Email = "ashish777@gmail.com", Phone=8317098849 };
            //Console.WriteLine("What is id :\nMy id is {0} ", student.Id);
            //Console.WriteLine("What is name :\nMy name is {0} ",student.Name);
            //Console.WriteLine("What is email :\nMy email is {0} ", student.Email);
            //Console.WriteLine("What is phone number :\nMy phone number is {0} ", student.Phone);

            //ArrayList arr = new ArrayList();
            //arr.Add(4);
            //arr.Add(5);
            //arr.Add(3);
            //arr.Add(9);
            //arr.Add(8);
            //arr.Sort();
            //arr.Reverse();

            //List<int> l = new List<int>();
            //l.Add(5);
            //l.Add(8);
            //l.Add(9);
            //l.Add(6);
            //SortedList<int,string> numberNames = new SortedList<int,string>();
            //numberNames.Add(2, "ashish");
            //numberNames.Add(4, "chetu");

            //foreach (var kvp in numberNames)
            //    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            //Stack<int> stc = new Stack<int>();
            //stc.Push(5);
            //stc.Push(9);
            //stc.Push(4);
            //stc.Push(2);
            ////stc.Pop();
            ////stc.Reverse<int>();
            ////Console.WriteLine(stc.Count);
            //foreach (var item in stc)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> qb = new Queue<int>();
            //qb.Enqueue(2);
            //qb.Enqueue(7);
            //qb.Enqueue(8);
            //qb.Enqueue(4);
            //qb.Dequeue();
            //foreach (var item in qb)
            //{
            //    Console.WriteLine(item);
            //}
            //try
            //{
            //    Console.WriteLine("Enter your name");
            //    string str = Console.ReadLine();
            //    if(str.StartsWith("Mr") || str.StartsWith("Mis"))
            //    {
            //        Console.WriteLine("Invaled Name");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Welcome: {0}",str);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Logger.WriteLog(ex.Message);
            //}
            //try
            //{
            //    Console.WriteLine("Enter your First number");
            //    int n1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the second number");
            //    int n2 = int.Parse(Console.ReadLine());
            //    int n3 = n1 / n2;
            //    Console.WriteLine(n3);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //    Logger.WriteLog(ex.Message);
            //    Logger.WriteLog(ex.StackTrace);
            //}



            //try
            //{
            //    Console.WriteLine("Enter four number");
            //    Console.WriteLine("Enter the first number");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the second number");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the third number");
            //    int c = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the fourth number");
            //    int d = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter your choice {1,2,3,4,5}");
            //    int options = int.Parse(Console.ReadLine());

            //    //if (options == 1)
            //    //{
            //    //    int Add = a + b + c + d;
            //    //    Console.WriteLine("Add value is {0}",Add);
            //    //}
            //    //else if (options == 2)
            //    //{
            //    //    int sub = (a + b) - (c + d);
            //    //    Console.WriteLine("substraction value is {0}",sub);
            //    //}
            //    //else if (options == 3)
            //    //{
            //    //    int mul = a * b * c * d;
            //    //    Console.WriteLine("Multiply value is {0}",mul);
            //    //}
            //    //else if (options == 4)
            //    //{
            //    //    int div = (a + b) / (c + d);
            //    //    Console.WriteLine("Devision vlue is {0}",div);
            //    //}
            //    //else if (options == 5)
            //    //{
            //    //    int avg = (a + b + c + d) / 4;
            //    //    Console.WriteLine("Average value is {0}", avg);
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("option invalide");
            //    //}

            //    switch (options)
            //    {
            //        case 1:
            //            int Add = a + b + c + d;
            //            Console.WriteLine("Add value is {0}", Add);
            //            break;

            //        case 2:
            //            int sub = (a + b) - (c + d);
            //            Console.WriteLine("substraction value is {0}", sub);
            //            break;

            //        case 3:
            //            int mul = a * b * c * d;
            //            Console.WriteLine("Multiply value is {0}", mul);
            //            break;

            //        case 4:
            //            int div = (a + b) / (c + d);
            //            Console.WriteLine("Devision vlue is {0}", div);
            //            break;

            //        case 5:
            //            int avg = (a + b + c + d) / 4;
            //            Console.WriteLine("Average value is {0}", avg);
            //            break;

            //        default:
            //            Console.WriteLine("invalide opration");
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //    Logger.WriteLog(ex.Message);
            //    Logger.WriteLog(ex.StackTrace);
            //}

            Console.WriteLine("Enter any text and convert to char");
            string str = Console.ReadLine();
            for(int i=0; i <= str.Length - 1; i++)
            { 
                Console.Write("{0} ", str[i]);
            }
            
            Console.ReadLine();
        }
    }
}