using System;

namespace HelloWorld
{


    class Car
    {

        public string Name {
            get;
        }

        public Car()
        {
            Name = "default_name";
        }
        public Car (string s)
        {
            Name = s;
        }

    }

    class Program { 

        static int Main(string[] args)
        {
            if (args.Length == 0)

                Console.WriteLine("Hello World!");

            else
            {
                string myName = args[0];
                Console.WriteLine("Hello World! Written by " + myName);
            }

            Car Polo = new Car("Camilla");
            Console.WriteLine("La mia auto si chiama " + Polo.Name);

      
            Console.WriteLine("Non posso cambiare il nome!");

            return 0;
        }


    }


}