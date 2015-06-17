using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Please enter positive number less than or equal to 100 :");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number >= 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine("Is the number prime : " + isPrime);
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
