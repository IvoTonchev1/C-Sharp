using System;
    class NumbersDividableByFive
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers: ");
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree;
            int number = 0;
            if (numOne > numTwo)
            {
                numThree = numOne;
                numOne = numTwo;
                numTwo = numThree;
            }
            for (int i = numOne; i <= numTwo; i++)
            {
                if(i % 5 == 0)
                {
                    number++;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Numbers dividable by 5 between the given two numbers: " + number);
        }
    }
