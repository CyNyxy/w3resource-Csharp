using System;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Write a C# Sharp program to check whether a given number is even or odd.

            int num, rem;

            Console.Write("Input number: ");
            num = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;

            if (rem == 0)
            {
                Console.WriteLine("{0} is an even integer", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer", num);
            }
        }
    }
}
