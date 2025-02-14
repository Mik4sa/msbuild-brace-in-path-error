using System;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var content = File.ReadAllText("test.txt");
                Console.WriteLine("File content: " + content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
