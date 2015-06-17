using System;
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if ((number < 1) || (number > 20))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                for (int column = 1; column <= number ; column++)
                {
                    for (int row = 0; row < number; row++)
                    {
                        Console.Write(column + row + "  ");
                    }
                    Console.WriteLine();
                }
            }        
        }
    }
