using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string password = string.Empty;
            while(x < 10)
            {
                WriteLine(x);
                x++;
            }

            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                if(password != "Pa$$w0rd")
                {
                    Console.WriteLine("Incorrect! Please try again");
                }
            } while (password != "Pa$$w0rd");
            WriteLine("Correct!");
        }
    }
}
