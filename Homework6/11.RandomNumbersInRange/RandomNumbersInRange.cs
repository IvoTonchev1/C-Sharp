using System;
    class RandomNumbersInRange
    {
        static void Main()
        {
            Console.Write("Please enter number of numbers: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter min value border: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max value border: ");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            if (min > max)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {           
                    Console.Write(rnd.Next(min, max + 1) + " ");
                }
                Console.WriteLine();
            }
        }
    }
