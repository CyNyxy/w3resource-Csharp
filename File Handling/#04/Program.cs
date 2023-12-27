using System.IO;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Write a program in C# to create a file and add some text.

            string Fichero = @"C:\Users\Nyxy\Desktop\mytest.txt";

            FileStream F1 = new FileStream(Fichero, FileMode.Create, FileAccess.Write);

            StreamWriter texto = new StreamWriter(F1);
            texto.WriteLine("oh!");
            texto.Close();
            F1.Close();

            //using (StreamWriter fileStr = File.CreateText(Fichero))
            //{
            //    fileStr.WriteLine("Hello");
            //}
        }
    }
}
