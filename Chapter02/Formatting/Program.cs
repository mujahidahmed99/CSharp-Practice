using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 1200;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);
            string formatted = string.Format(format: "{0} apples costs {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);
            Console.WriteLine(formatted);
            Console.WriteLine($"{numberOfApples:N0} apples costs {pricePerApple * numberOfApples:C}");
        }
    }
}
