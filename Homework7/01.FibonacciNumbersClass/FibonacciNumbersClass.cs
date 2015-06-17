using System;
    class FibonacciNumbersClass
    {
        static void Main()
        {
            Console.WriteLine("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
        }
        static int Fib(int n)
        {
            int numOne = 1;
            int numTwo = 1;
            int numThree = 0;
            int fib = 0;
            if (n == 0 || n == 1)
            {
                fib = 1;
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    numThree = numOne;
                    numOne = numTwo;
                    numTwo = numOne + numThree;
                }
                fib = numTwo;
            }
            return fib;
        }
    }