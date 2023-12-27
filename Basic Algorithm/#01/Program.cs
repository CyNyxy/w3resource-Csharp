using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Write a C# Sharp program to compute the sum of the two numerical values.
            // If the two values are the same, return triple their sum.

            int num1; int num2;
            Console.Write("Write number 1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Write number 2: ");
            num2 = Int32.Parse(Console.ReadLine());

            int result;

            if (num1 == num2)
            {
                result = (num1 + num2) * 3;
            }
            else
            {
                result = num1 + num2;
            }

            Console.Write("The result is: {0} ", result);
            Console.ReadKey();
        }
    }
}