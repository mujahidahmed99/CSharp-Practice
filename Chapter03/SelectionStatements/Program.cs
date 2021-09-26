using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            A_label:
            var number = (new Random()).Next(1,7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                WriteLine("One");
                break;
                case 2:
                WriteLine("Two");
                goto case 1;
                case 3:
                case 4:
                WriteLine("Three or Four");
                goto case 1;
                case 5:
                System.Threading.Thread.Sleep(500);
                goto A_label;
                default:
                WriteLine("Default");
                break;
            }
        }
    }
}
