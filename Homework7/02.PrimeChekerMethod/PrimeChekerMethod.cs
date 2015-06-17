using System;
    class PrimeChekerMethod
    {
        static void Main()
        {
            Console.Write("Please enter positive number : ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Is the number prime : " + isPrime(number));
        }
        static bool isPrime(long n)
        {
            int divider = 2;
            long maxDivider = (int)Math.Sqrt(n);
            bool prime = true;
            if (n < 2)
            {
                prime = false;
            }
            else
            {
                while (prime && (divider <= maxDivider))
                {
                    if (n % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
            }    
            return prime;
        }
    }