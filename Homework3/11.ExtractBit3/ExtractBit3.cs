using System;
    class ExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Please enter number : ");
            uint number = uint.Parse(Console.ReadLine());
            uint newNumber = number >> 3;
            if (newNumber % 2 == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
