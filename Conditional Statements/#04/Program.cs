using System;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Write a C# program to find out whether a given year is a leap year or not.

            int year;
            Console.Write("Input a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            //if (year % 4 == 0 && (!(year % 100 == 0) || (year % 400 == 0))) 
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}
