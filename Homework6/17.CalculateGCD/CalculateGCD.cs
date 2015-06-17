using System;
    class CalculateGCD
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers: ");
            int numOne = Math.Abs(int.Parse(Console.ReadLine()));
            int numTwo = Math.Abs(int.Parse(Console.ReadLine()));
            int gcd = 1;
            int numThree = 0;
            if (numOne > numTwo)
            {
                numThree = numTwo;
            }
            else if (numOne <= numTwo)
            {
                numThree = numOne;
            }
            for (int i = 1; i <= numThree; i++)
            {
                if ((numOne % i == 0) && (numTwo % i == 0))
                {
                    gcd = i;
                }
            }
            Console.WriteLine("GCD = " + gcd);
        }
    }
