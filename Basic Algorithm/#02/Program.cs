using System;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Write a C# Sharp program to get the absolute difference between n and 51.
            // If n is broader than 51 return triple the absolute difference.

            int n;
            Console.Write("Write number 1: ");
            n = Int32.Parse(Console.ReadLine());
            int result;

            int x = 51;

            if (n > x)
            {
                result = (n - x) * 3;
                Console.Write("The result is: {0} ", result);
            }
            else
            {
                result = x - n;
                Console.Write("The result is: {0} ", result);
            }

            Console.ReadKey();
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(test(53));
        //    Console.WriteLine(test(30));
        //    Console.WriteLine(test(51));
        //    Console.ReadLine();
        //}

        //public static int test(int n)
        //{
        //    const int x = 51;

        //    if (n > x)
        //    {
        //        return (n - x) * 3;
        //    }
        //    return x - n;
        //}
    }
}