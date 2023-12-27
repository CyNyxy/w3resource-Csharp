using System;
using System.IO;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Write a C# Sharp program to create a text file and read it.

            string Fichero = @"C:\Users\Nyxy\Desktop\mytest.txt";

            FileStream F1 = new FileStream(Fichero, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter sw = new StreamWriter(F1);
            sw.WriteLine("Hello!");

            StreamReader sr = new StreamReader(F1);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");

            sw.Close();
            F1.Close();


            //// Delete the file if it exists.
            //if (File.Exists(Fichero))
            //{
            //    File.Delete(Fichero);
            //}
            //Console.Write("\n\n Create a file with text and read the file  :\n");
            //Console.Write("-------------------------------------------------\n");
            //// Create the file.
            //using (StreamWriter fileStr = File.CreateText(Fichero))
            //{
            //    fileStr.WriteLine(" Hello and Welcome");
            //    fileStr.WriteLine(" It is the first content");
            //    fileStr.WriteLine(" of the text file mytest.txt");
            //}
            //using (StreamReader sr = File.OpenText(Fichero))
            //{
            //    string s = "";
            //    Console.WriteLine(" Here is the content of the file mytest.txt : ");
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    Console.WriteLine("");
            //}
        }
    }
}
