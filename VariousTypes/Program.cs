using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            uint un = 34U;
            short s = 12; //couldn't find a "tag" for a short int
            long l = 77L;
            Console.WriteLine($"{n}\n{un}\n{s}\n{l}");
        }
    }
}
