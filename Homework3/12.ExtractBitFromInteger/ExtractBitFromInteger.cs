using System;
  class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Please enter number and position : ");
            uint number = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            uint newNumber = number >> position;
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
