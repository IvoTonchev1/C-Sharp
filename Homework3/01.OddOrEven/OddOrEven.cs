using System;
    class OddOrEven
    {
        static void Main()
        {
            int varOne;
            Console.WriteLine("Please enter number:");
            varOne =  int.Parse(Console.ReadLine());

            bool isOddOrEven = (varOne % 2) == 1;
            Console.WriteLine("Is the number odd? : " + isOddOrEven);
        }
    }
