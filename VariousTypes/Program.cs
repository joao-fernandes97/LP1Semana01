using System;
using System.Text;


namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            
            int n = 5;
            uint un = 34U;
            short s = 12; //couldn't find a "tag" for a short int
            long l = 77L;
            Console.WriteLine($"{n}\n{un}\n{s}\n{l}");

            char triangle ='\u2C21';
            char eye = '\u0f17';
            char pog = '\u1435';
            char five = '\u168e';
            Console.WriteLine($"{triangle}\n{eye}\n{pog}\n{five}");
        }
    }
}
