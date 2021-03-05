using System;

namespace HelloWorld
{


    class Car
    {

        public string Name {
            get;
        }

        public int Year
        {
            get; set;
        }

        public Car()
        {
            Name = "default_name";
        }
        public Car (string s)
        {
            Name = s;
        }

        public Car (string s, int y)
        {
            Name = s;
            Year = y;
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

            Car Polo = new Car("Camilla",2014);
            Console.WriteLine("La mia auto del " + Polo.Year + " si chiama " + Polo.Name);

      
            Console.WriteLine("Non posso cambiare il nome!");
            Polo.Year = 2021;

            Console.WriteLine("Ora la mia auto è del " + Polo.Year);

            return 0;
        }


    }


}