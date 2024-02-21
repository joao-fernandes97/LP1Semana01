using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "A tab \t and a copyright sign\u03A9";
            string s2 = "\"\\\'\n\'\"\\\"\'\"\"";
            Console.WriteLine($"{s1}\n{s2}");

            string conc1 = "a"+2;
            string conc2 = "abc"+s2;
            string inter1 = $"value of conc1 is {conc1}";
            int x = 5;
            int y = 10;
            string inter2 = $"{x} plus {y} equals {x+y}";
            Console.WriteLine($"{conc1}\n{conc2}\n{inter1}\n{inter2}");

        }
    }
}
