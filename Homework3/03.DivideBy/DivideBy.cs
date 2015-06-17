using System;
    class DivideBy
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Please enter number:");
            number = int.Parse(Console.ReadLine());
            bool division = ((number % 5) == 0) && ((number % 7) == 0);
            Console.WriteLine("Does the number divide by both 5 and 7? : " + division);

        }
    }
