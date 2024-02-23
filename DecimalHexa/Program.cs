using System;

namespace DecimalHexa
{
    //ask 4 whole numbers
    //print numbers on screen 1 per line
    //in decimal and haxadecimal(Uppercase) format
    //right aligned, occupying 6 spaces with a spacing of 2 between them
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere 4 numeros inteiros:");
            string n1=Console.ReadLine();
            string n2=Console.ReadLine();
            string n3=Console.ReadLine();
            string n4=Console.ReadLine();

            int i1 = int.Parse(n1);
            int i2 = int.Parse(n2);
            int i3 = int.Parse(n3);
            int i4 = int.Parse(n4);

            Console.WriteLine($"{i1,6}  {i1,6:X}");
            Console.WriteLine($"{i2,6}  {i2,6:X}");
            Console.WriteLine($"{i3,6}  {i3,6:X}");
            Console.WriteLine($"{i4,6}  {i4,6:X}");
        }
    }
}
