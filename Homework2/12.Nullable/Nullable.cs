using System;
    class Nullable
    {
        static void Main()
        {
            int? varOne = null;
            double? varTwo = null;
            Console.WriteLine("Printing Nullable Values: {0} {1}", varOne, varTwo);

            varOne = varOne + 5;
            varTwo = varTwo + null;

            Console.WriteLine("Printing New Values: {0} {1}", varOne, varTwo);
        }
    }