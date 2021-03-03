using System;

namespace HelloWorld
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)

                Console.WriteLine("Hello World!");

            else
            {
                string myName = args[0];
                Console.WriteLine("Hello World! Written by " + myName);
            }

            return 0;
        }
    }
}
