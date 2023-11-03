using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

        static float Average(int a, int b, int c)
        {
          float sum = a + b + c;
            return sum/3;
        }

        static float Average(int a, int b)
        {
       
            return (a+b) / 2;
        }
      
        static void Main(string[] args)
        {


            /*int Nilanshu = 16;
            Console.WriteLine("Hello World");
            Console.Write("hello Nilanshu ");
            Console.WriteLine("I Love C# and I this no " + Nilanshu); 
            Console.ReadLine(); */

            /*  String str = Console.ReadLine();
              Console.WriteLine(str);
              Console.ReadLine();*/

            // int a = 67;
            // float b = 4F;
            // double c = 3D;
            // bool isGreat = true;
            // char d = 'N';
            // string s = "This is a string";
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(isGreat);
            // Console.WriteLine(s);
            // Console.WriteLine(d);
            // Console.ReadLine();

            // TypeCasting 
            // There are two types of types of typeCasting 
            // 1. Imlicit  Casting
            // char to int to long to float to double


            /* int x = 5;
             double y = x;
             int z = 'y';
             Console.WriteLine(y);
             Console.WriteLine(x);
             Console.WriteLine(z);
             Console.ReadLine();*/

            // 2. Explicit Casting
            /* int x = (int) 3.5;
             double x1 = (int)5.3;
             long r = (int)5.7;
             Console.WriteLine(x);
             Console.WriteLine(x1);
             Console.WriteLine(r);
             Console.ReadLine();*/

            //float varr = Convert.ToInt32(6.6);
            //float varr2 = Convert.ToInt64(7.6);
            //Console.WriteLine(varr);
            //Console.WriteLine(varr2);
            //Console.ReadLine();

            /*Console.WriteLine("Enter your Name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ",Welcome");

            Console.WriteLine("How many Candies do you want ?");
            String candies = Console.ReadLine();
            Console.WriteLine("You are lucky Customer, You will get 2 more candies for free: " + (Convert.ToInt32(candies) + 2));
            Console.ReadLine();*/

            /*Operators in C#
            1. Arithmetic operators
            2. Assignment Operators
            3 Logical Operators
            4. Comparison Operators
            */

            // a = 2;
            //int b = 3;
            //Console.WriteLine("The value of a + b is: " + (a + b));
            //Console.WriteLine("The value of a - b is: " + (a - b));
            //Console.WriteLine("The value of a * b is: " + (a * b));
            //Console.WriteLine("The value of a / b is: " + (a / b));
            // Console.ReadLine();

            // Assignmment operators

            /*  int a = 4;
              int b = a;
              b += 4;
              b -= 4;
              b *= 4;
              Console.WriteLine(b);
              Console.ReadLine();*/

            // Logical Operators

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.ReadLine();

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            // Comparison operator

            //Console.WriteLine(54 < 34);
            //Console.WriteLine(34 <= 77);
            //Console.WriteLine(55 != 56);
            //Console.WriteLine( 5 == 5);


            // int a = Math.Max(34, 345);
            //int a = Math.Min(4, 7);
            // int a = Math.Abs(-39);
            //double a = Math.Sqrt(4);

            //Console.WriteLine(a);
            //Console.ReadLine();

            //string hello = "Hello world this is Harry";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + " You are nice");
            //Console.WriteLine(string.Concat(hello , " YOu are Nice"));
            //Console.ReadLine();


            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies");
            //Console.ReadLine();


            /* string hello = "Hello world this is Harry";
             Console.WriteLine(hello[0]);
             Console.WriteLine(hello.IndexOf("Hello"));
             Console.WriteLine(hello.IndexOf("is"));
             Console.WriteLine(hello.Substring(5));
             Console.WriteLine(hello);


             string hello1 = "Hello world this \" is Harry";
             string hello2 = "Hello world this \n is Harry";
             string hello3 = "Hello world this \t is Harry";
             Console.WriteLine(hello1);
             Console.WriteLine(hello2);
             Console.WriteLine(hello3);
             Console.ReadLine();*/


            //Console.WriteLine("Enter your age");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //bool isbanned = true;
            //if (age < 2)
            //{

            //    Console.WriteLine("You are just born");
            //}
            //else if (age < 10 )
            //{
            //    Console.WriteLine("You should play with your friends");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You cannot drive");
            //}
            //else if (age<80)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine(" You cannot drive");
            //}

            //Console.ReadLine();

            //int age = 18;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("You are an adult now");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are amazing");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;
            //}
            //Console.ReadLine();

            // Loops in C sharp

            //int i = 0;
            //while (i < 5000)
            //{
            //    Console.WriteLine(i+1);
            //    i++;

            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;

            //} while (i < 5);
            // Console.ReadLine();


            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i + 1);
               break;
             }
                 Console.ReadLine();

            // Break and Continue
            // break - Leave this loop forever
            // continue - leave this particular iteration of the loop



            //Greet("Nilanshu");
            //Console.WriteLine(Average(2, 3, 5));
            //Console.WriteLine(Average(4, 6));
            //Console.ReadLine();

            // OOPS - Classes and Objects
            //Player tommy = new Player();
            //tommy.sethealth(25);  
            //Console.WriteLine(tommy.getHealth());
          
            //Console.ReadLine();

        }
    }
}
