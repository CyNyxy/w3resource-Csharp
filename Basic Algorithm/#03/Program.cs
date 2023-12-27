using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

            Console.Write("Write number 1: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write number 2: ");
            int m = Int32.Parse(Console.ReadLine());

            if (n == 30 || m == 30 || (n + m == 30))
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }

            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(test(30, 0));
        //    Console.WriteLine(test(25, 5));
        //    Console.WriteLine(test(20, 30));
        //    Console.WriteLine(test(20, 25));
        //    Console.ReadLine();
        //}

        //public static bool test(int x, int y)
        //{
        //    return x == 30 || y == 30 || (x + y == 30);
        //}

    }
}