using System;
    class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("Please enter number : ");
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 56;
            uint firstPart = (number & mask) >> 3;
            uint secondPart = (number & (mask << 21)) >> 24;
            number = number & ~(mask);
            number = number & ~(mask << 21);
            number = number | (firstPart << 24);
            number = number | (secondPart << 3);
            Console.WriteLine(number);
        }
    }
