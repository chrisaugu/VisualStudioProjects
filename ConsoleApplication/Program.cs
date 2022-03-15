using System;

namespace ConsoleApplication
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // addition
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            int number = 1234;
            string numberAsText = number.ToString();

            Console.WriteLine("String: " + numberAsText);

            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            WorkingWithIntegers();
            somefunction();
        }

        static void somefunction()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Whats your name?");
            Console.ReadLine();
            Console.WriteLine(@"
                hELLO
                SO
                sup?
            ");
        }
    }
}
