using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APP3._1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please write some words i will play it backwards");
            
            Thread.Sleep(500);
            Console.WriteLine("please write first word");
            string string1 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write second word");
            string string2 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write third word");
            string string3 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write fourth word");
            string string4 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write fifth word");
            string string5 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write sixth word");
            string string6 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write seventh word");
            string string7 = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("please write eighth word");
            string string8 = Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("please write ninth word");
            string string9 = Console.ReadLine();

            // Creates And Initializes A New Array.
            Array myArray = Array.CreateInstance(typeof(String), 9);
            myArray.SetValue(string1, 0);
            myArray.SetValue(string2, 1);
            myArray.SetValue(string3, 2);
            myArray.SetValue(string4, 3);
            myArray.SetValue(string5, 4);
            myArray.SetValue(string6, 5);
            myArray.SetValue(string7, 6);
            myArray.SetValue(string8, 7);
            myArray.SetValue(string9, 8);

            // Reverses The Sort Of The Values Of The Array.
            Array.Reverse(myArray);

            // Displays The Values Of The Array.
            Console.WriteLine("After reversing:");
            PrintIndexAndValues(myArray);
        }

        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
            Thread.Sleep(9000);
        }
    }
}