using System;
    class CalculateProblemSix
    {
        static void Main()
        {
            Console.WriteLine("Please enter first number n and and then number k such that 1<k<n<100 :");
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double sum = 1;
            double divider = 1;
            if ((n <= k) || (n <= 1) || (n >= 100) || (k <= 1) || (k >= 100))
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                for (int i = 1, j = 1; i <= n; i++, j++)
                {
                    sum *= i;
                    if (j > k)
                    {
                        continue;
                    }
                    divider *= j;
                }
                Console.WriteLine("n!/k! = " + (sum / divider));
            }
        }
    }
