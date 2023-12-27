using System;
using System.IO;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program in C# to remove a file from the disk.
            string Fichero = @"C:\Users\Nyxy\Desktop\mytest.txt";

            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
            Console.Write("--------------------------------------------------------------\n");

            if (File.Exists(Fichero))
            {
                File.Delete(Fichero);
                Console.WriteLine(" The file {0} deleted successfully.\n\n", Fichero);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}