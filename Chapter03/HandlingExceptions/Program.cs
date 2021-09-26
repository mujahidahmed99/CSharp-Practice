using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("what is your age? ");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"you are {age} years old.");
            }
            catch (System.Exception)
            {
            }
            WriteLine("After parsing");
        }
    }
}
