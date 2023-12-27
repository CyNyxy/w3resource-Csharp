using System.IO;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# Sharp to create a blank file on the disk.

            string File = @"C:\Users\Nyxy\Desktop\mytest.txt";

            FileStream F1 = new FileStream(File, FileMode.CreateNew);
        }
    }
}