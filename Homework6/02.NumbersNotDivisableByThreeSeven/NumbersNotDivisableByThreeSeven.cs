using System;
    class NumbersNotDivisableByThreeSeven
    {
        static void Main()
        {
            Console.Write("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
