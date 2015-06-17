using System;
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers: ");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree;
            if (numOne > numTwo)
            {
                numThree = numOne;
                numOne = numTwo;
                numTwo = numThree;
                Console.WriteLine(numOne + " " + numTwo);
            }
            else
            {
                Console.WriteLine(numOne + " " + numTwo);
            }

        }
    }