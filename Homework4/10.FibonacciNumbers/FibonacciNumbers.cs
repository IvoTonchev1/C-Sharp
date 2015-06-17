using System;
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            int numOne = 0;
            int numTwo = 1;
            int numThree;
            if (number == 1)
            {
                Console.WriteLine(numOne);
            }
            else if (number == 2)
            {
                Console.WriteLine(numOne + " " + numTwo);
            }
            else if (number >= 3)
            {
                Console.Write(numOne + " " + numTwo + " ");
                for (int i = 0; i < number - 2; i++)
                {
                    numThree = numOne;
                    numOne = numTwo;
                    numTwo = numOne + numThree;
                    Console.Write(numTwo + " ");
                }
                Console.WriteLine();
            }
        }
    }
