using System;
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Please enter number of numbers: ");
            int numbers = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is: " + sum);

        }
    }
