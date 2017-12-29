using System;
using System.Collections.Generic;
using System.Text;

namespace MyUri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is called with following parameters...");

            Console.WriteLine("Parameters:");
            foreach(string arg in args)
            {
                Console.Write('\t');
                Console.WriteLine(arg);
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}