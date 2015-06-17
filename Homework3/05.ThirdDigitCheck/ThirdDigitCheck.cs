using System;
    class ThirdDigitCheck
    {
        static void Main()
        {
            int digit;
            Console.WriteLine("Please enter number:");
            digit = Math.Abs(int.Parse(Console.ReadLine()));
            int thirdDigit = (digit / 100) % 10;
            bool result = thirdDigit == 7;
            Console.WriteLine("Is the third digit 7? : " + result);
        }
    }
