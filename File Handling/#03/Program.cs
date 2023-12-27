using System;
using System.IO;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Write a C# Sharp program to create a blank file on the disk if the same file already exists.

            string Fichero = @"C:\Users\Nyxy\Desktop\mytest.txt";

            // FileStream F1 = new FileStream(Fichero, FileMode.Create);

            if (File.Exists(Fichero))
            {
                File.Delete(Fichero);
            }
            Console.Write("\n\n Create a file in the disk if it is exists:\n");
            Console.Write("-----------------------------------------------\n");

            using (FileStream fileStr = File.Create(Fichero))
            {
                Console.WriteLine(" A file created with name mytest.txt\n\n");
            }
        }
    }
}
