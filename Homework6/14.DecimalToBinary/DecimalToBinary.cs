using System;
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Please enter decimal number: ");
            long number = long.Parse(Console.ReadLine());
            long remainder;
            string binary = string.Empty;
            if (number == 0)
            {
                Console.WriteLine("Binary number is : 0");
            }
            else
            {
                while (number > 0)
                {
                    remainder = number % 2;
                    number /= 2;
                    binary = remainder.ToString() + binary;
                }
                Console.WriteLine("Binary number is : " + binary);
            }     
        }
    }
