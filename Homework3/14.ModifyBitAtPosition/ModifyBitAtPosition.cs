using System;
    class ModifyBitAtPosition
    {
        static void Main()
        {
            Console.WriteLine("Please enter number, position and value (0 or 1) : ");
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            if(value == 0)
            {
                number = number & ~(1 << position);
            }
            else
            {
                number = number | (1<< position);
            }
            Console.WriteLine(number);
        }
    }
