using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Write a C# Sharp program to check whether a given number is positive or negative.

            int num;

            Console.Write("Input number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("{0} is a positive number.", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number.", num);
            }
        }
    }
}
