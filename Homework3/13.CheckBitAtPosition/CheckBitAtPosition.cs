using System;
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.WriteLine("Please enter number and position : ");
            uint number = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            uint newNumber = number >> position;
            bool result = false;
            if (newNumber % 2 == 1)
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
