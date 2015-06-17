using System;
    class SumThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter three real numbers:");
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is : " + (numOne + numTwo + numThree));
        }
    }
