// See https://aka.ms/new-console-template for more information
using System;
namespace newClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            bool flag = false;
            double specify = 14.234;

            double bedding = 14.234f;


            string username = "Royalty";
            char password = 'B';

            Console.WriteLine($"Int has a value of {num}");
            Console.WriteLine($"Boolean has a value of {flag}");
            Console.WriteLine($"double has a value of {specify}");
            Console.WriteLine($"float has a value of {bedding}");

            Console.WriteLine($"String has a value of {username}");
            Console.WriteLine($"Char has a value of {password}");
        }
    }
}
