using System;

namespace Console_App
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First Console App");
            /*
            Console.WriteLine("using static method");
            Calc.add(5, 3);*/

            Calc calc = new Calc();
            Console.WriteLine("Using non static method");
            calc.sum(10, 20);


            
        }

        
    }
}
