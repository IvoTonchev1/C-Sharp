using System;
using System.Numerics;
  class TrailingZeroes
    {
        static void Main()
        {
            Console.Write("Please enter number : ");
            int number = int.Parse(Console.ReadLine());
            BigInteger sum = new BigInteger(1);
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            while (sum % 10 == 0)
            {
                sum /= 10;
                count++;
            }
            Console.WriteLine("Trailing zeroes : " + count);       
        }
    }
