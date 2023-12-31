using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to accept two integers and check whether they are equal or not.

            Console.Write("Input 1st number: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int b = Int32.Parse(Console.ReadLine());
                    //Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.Write("{0} and {1} are equal", a,b);
            }
            else
            {
                Console.Write("{0} and {1} are not equal", a,b);
            }
        }
    }
}