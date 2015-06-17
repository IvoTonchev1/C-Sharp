using System;
    class NumbersOneToN
    {
        static void Main()
        {
            Console.Write("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
