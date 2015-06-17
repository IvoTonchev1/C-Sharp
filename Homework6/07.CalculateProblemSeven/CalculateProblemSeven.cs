using System;
    class CalculateProblemSeven
    {
        static void Main()
        {
            Console.WriteLine("Please enter first number n and and then number k such that 1<k<n<100 :");
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double sumN = 1;
            double dividerK = 1;
            double diff = n - k;
            double sumDiff = 1;
            if ((n <= k) || (n <= 1) || (n >= 100) || (k <= 1) || (k >= 100))
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                for (int i = 1, j = 1; i <= n; i++, j++)
                {
                    sumN *= i;
                    if (j > k)
                    {
                        continue;
                    }
                    dividerK *= j;
                }
                for (int l = 1; l <= diff ; l++)
                {
                    sumDiff *= l;
                }
                Console.WriteLine("Number of combinations : " + ((sumN) / (dividerK * sumDiff)));
            }
        }
    }
