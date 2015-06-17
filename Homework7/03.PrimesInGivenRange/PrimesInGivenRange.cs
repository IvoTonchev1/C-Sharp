using System;
using System.Collections.Generic;
    class PrimesInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Please enter the range: ");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join<int>(",", FindPrimesInRange(start, end)));
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            int divider = 2;           
            bool prime = true;
            int maxDivider = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                maxDivider = (int)Math.Sqrt(i);
                prime = true;
                if (i < 2)
                {
                    prime = false;
                    continue;
                }
                else
                {
                    for (int j = divider; j <= maxDivider; j++)
			        {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
			        }
                    if (prime)
                    {
                        primes.Add(i);
                    }
                }  
            }
            return primes;
        }
    }
