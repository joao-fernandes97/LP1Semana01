using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Um tab \t e um copyright\u03A9";
            string s2 = "\"\\\'\n\'\"\\\"\'\"\"";
            Console.WriteLine($"{s1}\n{s2}");
        }
    }
}
