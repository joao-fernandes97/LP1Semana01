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

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
