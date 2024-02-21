using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a number");
            string str = Console.ReadLine();
            int i = int.Parse(str);
            Console.WriteLine("Now enter a decimal number");
            str = Console.ReadLine();
            float f = float.Parse(str);

            Console.WriteLine($"{i+f}");
        }
    }
}
