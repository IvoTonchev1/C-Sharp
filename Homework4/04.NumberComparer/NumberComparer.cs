using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double numOne = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Greater number is: " + (numOne > numTwo ? numOne : numTwo));
        }
    }
