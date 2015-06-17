using System;
using System.Linq;
    class MinMaxSumAverage
    {
        static void Main()
        {
            Console.WriteLine("Please enter number of numbers: ");
            int number = int.Parse(Console.ReadLine());
            int[] all = new int[number];
            for (int i = 1; i <= number; i++)
            {
                all[i - 1] = int.Parse(Console.ReadLine());
            }
            int min = all.Min();
            int max = all.Max();
            int sum = all.Sum();
            double avg = all.Average();
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3}", min, max, sum, avg);
        }
    }
